using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Controllers
{
    [Route("Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        //private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMailService _mailService;
        private readonly IConfiguration _configuration;

        public AccountController(
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
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if(user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var clientUrl = _configuration["Endpoints:Client"];
                var url = clientUrl + Url.Action(nameof(ResetPassword), new { token = token, email = user.Email });

                var mailData = new MailData
                {
                    EmailToId = user.Email,
                    EmailSubject = "Resetowanie hasła",
                    EmailBody = url,
                };

                await _mailService.SendMailAsync(mailData);
            }

            return Ok(new SuccedResponse
            {
                Message = "Link do resetowania hasła został wysłany."
            });
        }

        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if(user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, request.Token, request.Password);
                if(result.Errors.Any()) 
                {
                    return StatusCode(
                        StatusCodes.Status500InternalServerError,
                        new ErrorResponse
                        {
                            Message = "Wystąpił problem podczas próby resetowania hasła.",
                            Errors = result.Errors.ToDictionary(e => e.Code, e => new[] { e.Description })
                        });
                }

                return Ok(new SuccedResponse
                {
                    Message = "Hasło zostało zresetowane."
                });
            }

            return BadRequest(new ErrorResponse
            {
                Errors = new Dictionary<string, string[]> {
                    { "url", new[] { "Link wygasł." } }
                }
            });
        }
    }
}
