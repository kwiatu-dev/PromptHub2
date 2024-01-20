using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Controllers;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Data;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Entites.Extensions;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Results;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Web;

namespace PromptHub2.Server.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMailService _mailService;
        private readonly IJwtUtilsService _jwtUtilsService;
        private readonly IConfiguration _configuration;

        public AuthenticateService(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            IMailService mailService,
            IJwtUtilsService jwtTokenCreatorService,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailService = mailService;
            _jwtUtilsService = jwtTokenCreatorService;
            _configuration = configuration;
        }

        public async Task<LoginResult> LogInAsync(LoginRequest request, string ipAddress)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, true);

                if (result.Succeeded)
                {
                    var accessToken = await _jwtUtilsService.CreateAccessTokenAsync(user);
                    var refreshToken = _jwtUtilsService.CreateRefreshToken(ipAddress);
                    user.RefreshTokens.Add(refreshToken);
                    _jwtUtilsService.RemoveObsoleteRefreshTokensAsync(user);
                    await _userManager.UpdateAsync(user);

                    return new LoginResult { 
                        IsSuccess = true, 
                        AccessToken = accessToken,
                        RefreshToken = refreshToken,
                        User = await user.GenerateResponse(_userManager),
                        Message = Messages.LoginSuccessful
                    };
                }
                else if (result.IsLockedOut)
                {
                    return new LoginResult
                    {
                        IsSuccess = false,
                        Message = Errors.LoginAttemptsExceeded,
                        Errors = new Dictionary<string, string[]>
                        {
                            { "email", new[] { Errors.LoginAttemptsExceeded } }
                        },
                        StatusCode = StatusCodes.Status423Locked
                    };
                }
                else if (result.IsNotAllowed)
                {
                    return new LoginResult
                    {
                        IsSuccess = false,
                        Message = Errors.NotVerifiedEmail,
                        Errors = new Dictionary<string, string[]>
                        {
                            { "email", new[] { Errors.NotVerifiedEmail } }
                        },
                        StatusCode = StatusCodes.Status400BadRequest
                    };
                }
            }

            return new LoginResult
            {
                IsSuccess = false,
                Message = Errors.InvalidEmailOrPassword,
                Errors = new Dictionary<string, string[]>
                {
                    { "email", new[] { Errors.InvalidEmailOrPassword } }
                },
                StatusCode = StatusCodes.Status400BadRequest
            };
        }

        public async Task<RegisterResult> RegisterAsync(RegisterRequest request)
        {
            var user = new User
            {
                UserName = request.Email,
                Email = request.Email
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Errors.Any())
            {
                var confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var baseUrl = _configuration["Endpoints:Client"];
                var confirmationLink = $"{baseUrl}/Authenticate/{nameof(AuthenticateController.ConfirmEmail)}?token={HttpUtility.UrlEncode(confirmationToken)}&email={HttpUtility.UrlEncode(user.Email)}";

                var mailData = new MailData
                {
                    EmailToId = user.Email,
                    EmailSubject = "Email address verification",
                    EmailBody = confirmationLink
                };

                await _mailService.SendMailAsync(mailData);

                return new RegisterResult
                {
                    IsSuccess = true,
                    Message = Messages.UserCreated,
                    StatusCode = StatusCodes.Status200OK
                };
            }

            return new RegisterResult
            {
                IsSuccess = false,
                Message = Errors.CreateUserError,
                Errors = new Dictionary<string, string[]>
                {
                    { "email", result.Errors.Select(e => e.Description).ToArray() }
                },
                StatusCode = StatusCodes.Status400BadRequest
            };
        }

        public async Task<LoginResult> RefreshTokenAsync(string token, string ipAddress)
        {
            var user = _jwtUtilsService.GetUserByToken(token);

            if (user != null)
            {
                var refreshToken = user.RefreshTokens.SingleOrDefault(t => t.Token == token);

                if (refreshToken != null)
                {
                    if (refreshToken.IsRevoked)
                    {
                        _jwtUtilsService.RevokeDescendantRefreshTokens(user, refreshToken, string.Format(Messages.ReuseRevokedToken, token), ipAddress);
                        await _userManager.UpdateAsync(user);
                    }

                    if (refreshToken.IsActive)
                    {
                        var newAccessToken = await _jwtUtilsService.CreateAccessTokenAsync(user);
                        var newRefreshToken = _jwtUtilsService.RotateRefreshToken(refreshToken, ipAddress);
                        user.RefreshTokens.Add(newRefreshToken);
                        _jwtUtilsService.RemoveObsoleteRefreshTokensAsync(user);
                        await _userManager.UpdateAsync(user);

                        return new LoginResult()
                        {
                            IsSuccess = true,
                            AccessToken = newAccessToken,
                            RefreshToken = newRefreshToken,
                            User = await user.GenerateResponse(_userManager),
                            Message = Messages.RefreshTokenSuccessful,
                        };
                    }
                }
            }

            return new LoginResult()
            {
                IsSuccess = false,
                Message = Errors.RefreshTokenFailed,
            };
        }

        public async Task<bool> LogOutAsync(string token, string ipAddress)
        {
            return await _jwtUtilsService.RevokeTokenAsync(token, "LogOut", ipAddress);
        }

        public async Task<ConfirmEmailResult> ConfirmEmailAsync(ConfirmEmailRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, request.Token);

                if (!result.Errors.Any())
                {
                    return new ConfirmEmailResult { 
                        IsSuccess = true,
                        Message = Messages.EmailVerifiedSuccessful,
                    };
                }
            }

            return new ConfirmEmailResult
            {
                IsSuccess = false,
                Message = Errors.LinkExpired,
                StatusCode = StatusCodes.Status400BadRequest
            };
        }
    }
}
