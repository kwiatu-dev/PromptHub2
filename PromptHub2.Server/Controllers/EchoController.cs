using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Controllers
{
    [Authorize(Roles = "admin")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        [HttpPost("echo")]
        public IActionResult Post(EchoRequest request)
        {
            return Ok(new SuccedResponse { Message = request.Message });
        }
    }
}
