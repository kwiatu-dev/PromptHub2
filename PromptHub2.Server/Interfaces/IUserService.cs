using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetAuthenticatedUserAsync();
    }
}