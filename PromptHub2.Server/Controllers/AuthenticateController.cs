using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
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
        [Route("LogIn")]
        public async Task<IActionResult> LogIn(LoginRequest request)
        {
            var result = await _authenticateService.LogInAsync(request, GetIpAddress());

            if (result.IsSuccess)
            {
                Response.Cookies.Append(Cookies.RefreshToken, result?.RefreshToken?.Token ?? "");

                return Ok(new
                {
                    user = result?.User,
                    token = result?.AccessToken
                });
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
            if (Request.Cookies.TryGetValue(Cookies.RefreshToken, out var token))
            {
                var result = await _authenticateService.RefreshTokenAsync(token, GetIpAddress());

                if (result.IsSuccess)
                {
                    Response.Cookies.Append(Cookies.RefreshToken, result?.RefreshToken?.Token ?? "");

                    return Ok(new
                    {
                        user = result?.User,
                        token = result?.AccessToken
                    });
                }
            }

            return Unauthorized(new ErrorResponse
            {
                Message = Errors.RefreshTokenFailed,
            });
        }

        [Authorize]
        [HttpDelete]
        [Route("LogOut")]
        public async Task<IActionResult> LogOut()
        {
            if (Request.Cookies.TryGetValue(Cookies.RefreshToken, out var token))
            {
                var result = await _authenticateService.LogOutAsync(token, GetIpAddress());

                if (result)
                {
                    return Ok(new SuccedResponse
                    {
                        Message = Messages.LogOutSuccessful
                    });
                }
            }

            return BadRequest(new ErrorResponse
            {
                Message = Errors.LogOutFailed,
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

        private string GetIpAddress()
        {
            if (Request.Headers.TryGetValue("X-Forwarded-For", out StringValues header))
            {
                return header.ToString();
            }
            else
            {
                var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;

                if (remoteIpAddress != null)
                {
                    return remoteIpAddress.MapToIPv4().ToString();
                }
                
                return string.Empty;
            }
        }
    }
}
