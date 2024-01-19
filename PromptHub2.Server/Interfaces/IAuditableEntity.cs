using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Interfaces
{
    public interface IAuditableEntity
    {
        DateTime? CreatedAt { get; set; }
        User? CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        User? UpdatedBy { get; set; }
    }
}
