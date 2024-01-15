using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Interfaces;

namespace PromptHub2.Server.Services
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;

        public UserService(
            IHttpContextAccessor httpContextAccessor, 
            UserManager<IdentityUser> userManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        public async Task<IdentityUser?> GetAuthenticatedUserAsync()
        {
            var userClaims = _httpContextAccessor.HttpContext?.User;

            if(userClaims != null)
            {
                return await _userManager.GetUserAsync(userClaims);
            }

            return null;
        }
    }
}
