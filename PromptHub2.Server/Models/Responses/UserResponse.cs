namespace PromptHub2.Server.Models.Responses
{
    public record UserResponse(
        string Email,
        List<string>? Roles);
}
