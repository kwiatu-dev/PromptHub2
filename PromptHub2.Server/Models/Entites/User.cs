using Microsoft.AspNetCore.Identity;

namespace PromptHub2.Server.Models.Entites
{
    public class User : IdentityUser
    {
        public string? RefreshToken { get; set; }
    }
}
