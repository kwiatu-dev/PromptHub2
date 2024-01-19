using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Models.Results
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public string Token { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public User? User { get; set; }
        public string? Message { get; set; }
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
        public int StatusCode { get; set; }
    }
}
