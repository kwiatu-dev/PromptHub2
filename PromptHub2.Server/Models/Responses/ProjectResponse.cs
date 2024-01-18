using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Models.Entites;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PromptHub2.Server.Models.Responses
{
    public record ProjectResponse(
        string? Id,
        string? Name,
        string? Description,
        ICollection<Prompt>? prompts,
        int? PromptsCount,
        string? CreatedAt,
        string? UpdatedAt,
        string? DeletedAt);
}
