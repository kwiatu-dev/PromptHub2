using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Services;

namespace PromptHub2.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        public MailController(IMailService mailService) 
        {
            _mailService = mailService;
        }

        [HttpPost]
        [Route("SendMail")]
        public bool SendMail(MailData mailData)
        {
            return _mailService.SendMail(mailData);
        }
    }
}
