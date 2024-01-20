using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Interfaces
{
    public interface IJwtUtilsService
    {
        public Task<string> CreateAccessTokenAsync(User user);
        public string? ValidateAccessToken(string accessToken);
        public RefreshToken CreateRefreshToken(string ipAddress);
    }
}
