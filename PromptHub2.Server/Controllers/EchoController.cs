using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Infrastructure;
using PromptHub2.Server.Models;
using System.Net;

namespace PromptHub2.Server.Controllers
{
    [Authorize]
    [ApiController]
    public class EchoController : ControllerBase
    {
        [HttpPost("echo")]
        public IActionResult Post(EchoRequest request)
        {
            //throw new Exception("To jest błąd symulowany w kontrolerze SomeController");
            return Ok(new SuccedResponse { Message = request.Message });
        }

    }
}
