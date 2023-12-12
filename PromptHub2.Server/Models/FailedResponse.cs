namespace PromptHub2.Server.Models
{
    public class FailedResponse
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
        public List<string> Errors { get; set; } = new List<string>();
    }
}
