using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;
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
                return Ok(new { token = result.Token });
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
