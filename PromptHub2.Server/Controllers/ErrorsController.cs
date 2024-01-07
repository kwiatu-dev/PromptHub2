using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorsController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            return StatusCode(
                StatusCodes.Status500InternalServerError, 
                new ErrorResponse
                {
                    Message = Errors.ServerConfigurationError
                });
        }
    }
}
