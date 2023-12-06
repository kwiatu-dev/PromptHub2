using Microsoft.AspNetCore.Identity;

namespace PromptHub2.Server.Interfaces
{
    public interface IAuditableEntity
    {
        DateTime? CreatedAt { get; set; }
        IdentityUser? CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        IdentityUser? UpdatedBy { get; set; }
    }
}
