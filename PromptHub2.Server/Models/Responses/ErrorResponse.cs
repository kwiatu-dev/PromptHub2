using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PromptHub2.Server;

namespace PromptHub2.Server.Models.Responses
{
    public class ErrorResponse
    {
        public string? Status { get; set; } = "Error";
        public string? Message { get; set; } = Constants.Errors.ErrorOccurred;
        public Dictionary<string, string[]> Errors { get; set; } = new Dictionary<string, string[]>();
    }


}
