using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites.Extensions;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Controllers
{
    [Route("Authenticate")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;

        public AuthenticateController(IAuthenticateService authenticateService) 
        {
            _authenticateService = authenticateService;
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var result = await _authenticateService.LoginAsync(request);

            if (result.IsSuccess)
            {
                Response.Cookies.Append(Cookies.AccessToken, result.Token);
                Response.Cookies.Append(Cookies.RefreshToken, result.RefreshToken);
                Response.Cookies.Append(Cookies.UserEmail, result.Email);

                return Ok(result.User.GenerateResponse());
            }

            return StatusCode(result.StatusCode, new ErrorResponse
            {
                Message = result.Message,
                Errors = result.Errors,
            });
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var result = await _authenticateService.RegisterAsync(request);

            if (result.IsSuccess)
            {
                return Ok(new SuccedResponse
                {
                    Message = result.Message
                });
            }

            return StatusCode(result.StatusCode, new ErrorResponse
            {
                Message = result.Message,
                Errors = result.Errors,
            });
        }

        [HttpGet]
        [IgnoreAntiforgeryToken]
        [Route("Refresh")]
        public async Task<ActionResult> Refresh()
        {
            if (Request.Cookies.TryGetValue(Cookies.UserEmail, out var userEmail) &&
               Request.Cookies.TryGetValue(Cookies.RefreshToken, out var refreshToken))
            {
                var result = await _authenticateService.RefreshTokenAsync(userEmail, refreshToken);

                if (result.IsSuccess)
                {
                    Response.Cookies.Append(Cookies.AccessToken, result.Token);
                    Response.Cookies.Append(Cookies.RefreshToken, result.RefreshToken);
                    Response.Cookies.Append(Cookies.UserEmail, result.Email);

                    return Ok(result.User.GenerateResponse());
                }
            }

            return Unauthorized(new ErrorResponse
            {
                Message = Errors.RefreshTokenFail,
            });
        }

        [HttpPost]
        [Route("ConfirmEmail")]
        [IgnoreAntiforgeryToken]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> ConfirmEmail(ConfirmEmailRequest request)
        {
            var result = await _authenticateService.ConfirmEmailAsync(request);

            if (result.IsSuccess)
            {
                return Ok(new SuccedResponse
                {
                    Message = result.Message
                });
            }

            return StatusCode(result.StatusCode, new ErrorResponse
            {
                Message = result.Message,
            });
        }
    }
}
