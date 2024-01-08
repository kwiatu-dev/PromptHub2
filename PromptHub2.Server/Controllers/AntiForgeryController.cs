using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PromptHub2.Server.Controllers
{
    [Authorize]
    [Route("antiforgery")]
    [ApiController]
    public class AntiForgeryController : ControllerBase
    {
        private readonly IAntiforgery _forgeryService;

        public AntiForgeryController(IAntiforgery forgeryService) 
        { 
            _forgeryService = forgeryService;
        }

        [HttpGet]
        [Route("token")]
        public IActionResult GetAntiForgeryToken()
        {
            var tokens = _forgeryService.GetAndStoreTokens(HttpContext);

            return Ok(new { token = tokens.RequestToken });
                
        }
    }
}
