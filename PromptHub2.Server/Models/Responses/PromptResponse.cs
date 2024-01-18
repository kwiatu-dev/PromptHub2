using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Models.Responses
{
    public record PromptResponse(
        string? Id,
        string? ProjectId,
        string? Name,
        string? Description,
        string? Model,
        uint? Tokens,
        List<Message>? Messages,
        int? MessagesCount,
        string? CreatedAt,
        string? UpdatedAt,
        string? DeletedAt);
}
