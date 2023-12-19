using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Validations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PromptHub2.Server.Controllers
{
    [Route("Authenticate")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMailService _mailService;
        private readonly IConfiguration _configuration;

        public AuthenticateController(
            UserManager<IdentityUser> userManager, 
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            IMailService mailService,
            IConfiguration configuration
            ) 
        {
            _userManager = userManager;
            _signInManager = signInManager;
            //_roleManager = roleManager;
            _mailService = mailService;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
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
                        new(ClaimTypes.Email, request.Email),
                        new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    };

                    foreach (var role in userRoles)
                    {
                        authClaims.Add(new Claim(ClaimTypes.Role, role));
                    }

                    var token = CreateToken(authClaims);

                    return Ok(new { 
                        token = new JwtSecurityTokenHandler().WriteToken(token),
                    });
                }
                else if(result.IsLockedOut)
                {
                    return StatusCode(
                        StatusCodes.Status423Locked, 
                        new ErrorResponse { 
                            Errors = new Dictionary<string, string[]>
                            {
                                { "authentication", new[] { "Przeroczono limit prób logowania." } }
                            }
                        });
                }
                else if (result.IsNotAllowed)
                {
                    return BadRequest(
                        new ErrorResponse
                        {
                            Errors = new Dictionary<string, string[]>
                            {
                                { "ConfirmEmail", new[] { "Zweryfikuj adres email." } }
                            }
                        });
                }
            }

            return Unauthorized(new ErrorResponse
            {
                Errors = new Dictionary<string, string[]> 
                {
                    { "authentication", new[] { "Nieprawidłowy adres email lub hasło." } }
                }
            });
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var user = new IdentityUser
            {
                UserName = request.Email,
                Email = request.Email
            };

            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Errors.Any())
            {
                return StatusCode(
                    StatusCodes.Status500InternalServerError, 
                    new ErrorResponse { 
                        Message = "Wystąpił problem podczas próby utworzenia użytkownika.",
                        Errors = result.Errors.ToDictionary(e => e.Code, e => new[] { e.Description } )
                    });
            }

            var confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var clientUrl = _configuration["Endpoints:Client"];
            var confirmationLink = clientUrl + Url.Action(nameof(ConfirmEmail), new { token = confirmationToken, email = user.Email });

            var mailData = new MailData
            {
                EmailToId = user.Email,
                EmailSubject = "Weryfikacja adresu email",
                EmailBody = confirmationLink
            };

            await _mailService.SendMailAsync(mailData);

            return Ok(new SuccedResponse { 
                Message = "Użytkownik został pomyślnie utworzony."
            });
        }

        [HttpPost]
        [Route("ConfirmEmail")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ConfirmEmail(ConfirmEmailRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, request.Token);

                if(result.Errors.Any())
                {
                    return BadRequest(
                        new ErrorResponse
                        {
                            Message = "Nie udało się zweryfikować adresu email.",
                            Errors = result.Errors.ToDictionary(e => e.Code, e => new[] { e.Description })
                        });
                }
                else
                {
                    return Ok(new SuccedResponse
                    {
                        Message = "Adres email został zwerfikowany pomyślnie."
                    });
                }
            }

            return BadRequest(new ErrorResponse
            {
                Errors = new Dictionary<string, string[]> { 
                    { "url", new[] { "Link wygasł." } }
                }
            });
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
