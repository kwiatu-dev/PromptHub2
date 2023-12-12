using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PromptHub2.Server.Models
{
    public class ErrorResponse
    {
        public string? Status { get; set; } = "Error";
        public string? Message { get; set; } = "Wystąpił jeden lub więcej błędów.";
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }
}
