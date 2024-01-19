using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<User> _userManager;

        public UserService(
            IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<User?> GetAuthenticatedUserAsync()
        {
            var userClaims = _httpContextAccessor.HttpContext?.User;

            if (userClaims != null)
            {
                return await _userManager.GetUserAsync(userClaims);
            }

            return null;
        }
    }
}
