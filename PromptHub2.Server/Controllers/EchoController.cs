using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Infrastructure;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    [Route("[controller]")]
    [ApiController]
    public class EchoController : ControllerBase
    {
        [HttpPost(Name = "Echo")]
        public IActionResult Post([FromBody] EchoModel model)
        {
            return Ok(new Response { Status = "Success", Message = model.Message });
        }

    }
}
