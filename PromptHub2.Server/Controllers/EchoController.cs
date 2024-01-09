using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Models;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;
using System.Net;

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
