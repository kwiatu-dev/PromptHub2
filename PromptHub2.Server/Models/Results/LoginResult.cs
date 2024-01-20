using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Models.Results
{
    public class LoginResult
    {
        public bool IsSuccess { get; set; }
        public string AccessToken { get; set; } = string.Empty;
        public RefreshToken? RefreshToken { get; set; } 
        public User? User { get; set; }
        public string? Message { get; set; }
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
        public int StatusCode { get; set; }
    }
}
