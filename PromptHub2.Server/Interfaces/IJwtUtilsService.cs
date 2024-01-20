using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Interfaces
{
    public interface IJwtUtilsService
    {
        Task<string> CreateAccessTokenAsync(User user);
        RefreshToken CreateRefreshToken(string ipAddress);
        User? GetUserByToken(string token);
        void RemoveObsoleteRefreshTokensAsync(User user);
        void RevokeDescendantRefreshTokens(User user, RefreshToken refreshToken, string? reasonRevoked = null, string? ipAddress = null);
        void RevokeRefreshToken(RefreshToken refreshToken, string? replaceByToken = null, string? reasonRevoked = null, string? ipAddress = null);
        Task<bool> RevokeTokenAsync(string token, string reasonRevoked, string ipAddress);
        RefreshToken RotateRefreshToken(RefreshToken refreshToken, string ipAddress);
    }
}