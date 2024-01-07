using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Controllers;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Models.Data;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Results;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Policy;
using System.Text;
using System.Web;

namespace PromptHub2.Server.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMailService _mailService;
        private readonly IConfiguration _configuration;

        public AuthenticateService(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IMailService mailService,
            IConfiguration configuration
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailService = mailService;
            _configuration = configuration;
        }

        public async Task<LoginResult> LoginAsync(LoginRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, true);

                if (result.Succeeded)
                {
                    var userRoles = await _userManager.GetRolesAsync(user);

                    var authClaims = new List<Claim>
                    {
                        new(ClaimTypes.NameIdentifier, user.Id),
                        new(ClaimTypes.Email, request.Email),
                        new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    foreach (var role in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var token = CreateToken(authClaims);

                    return new LoginResult { IsSuccess = true, Token = new JwtSecurityTokenHandler().WriteToken(token) };
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
            var user = new IdentityUser
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

        private JwtSecurityToken CreateToken(List<Claim> authClaims)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"] ?? ""));

            var token = new JwtSecurityToken(
                claims: authClaims,
                notBefore: DateTime.UtcNow,
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddDays(7),
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature)
            );

            return token;
        }
    }
}
