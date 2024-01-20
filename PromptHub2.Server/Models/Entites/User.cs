using Microsoft.AspNetCore.Identity;

namespace PromptHub2.Server.Models.Entites
{
    public class User : IdentityUser
    {
        public List<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
    }
}
