using Microsoft.AspNetCore.Identity;

namespace PromptHub2.Server.Interfaces
{
    public interface IUserService
    {
        Task<IdentityUser?> GetAuthenticatedUserAsync();
    }
}