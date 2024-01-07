using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Interfaces
{
    public interface IAccountService
    {
        Task<bool> ForgotPasswordAsync(ForgotPasswordRequest request);
        Task<bool> ResetPasswordAsync(ResetPasswordRequest request);
    }
}
