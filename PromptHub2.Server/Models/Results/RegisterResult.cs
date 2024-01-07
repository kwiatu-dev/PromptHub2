namespace PromptHub2.Server.Models.Results
{
    public class RegisterResult
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
        public int StatusCode { get; set; }

    }
}
