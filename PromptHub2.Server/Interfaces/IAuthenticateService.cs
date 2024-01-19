using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Results;

namespace PromptHub2.Server.Interfaces
{
    public interface IAuthenticateService
    {
        Task<LoginResult> LoginAsync(LoginRequest request);
        Task<RegisterResult> RegisterAsync(RegisterRequest request);
        Task<LoginResult> RefreshTokenAsync(string? userEmail, string? refreshToken);
        Task<ConfirmEmailResult> ConfirmEmailAsync(ConfirmEmailRequest request);
    }
}
