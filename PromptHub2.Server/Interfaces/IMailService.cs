using PromptHub2.Server.Models.Data;

namespace PromptHub2.Server.Interfaces
{
    public interface IMailService
    {
        bool SendMail(MailData mailData);
        Task<bool> SendMailAsync(MailData mailData);
    }
}
