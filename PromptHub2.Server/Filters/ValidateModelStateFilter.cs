using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Validations
{
    public class ValidateModelStateFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context) 
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Any())
                    .ToDictionary(
                        kvp => kvp.Key.ToLower(),
                        kvp => kvp.Value?.Errors?
                            .Where(error => error != null)
                            .Select(error => error.ErrorMessage)
                            .ToArray() ?? Array.Empty<string>()
                    );

                var errorResponse = new ErrorResponse
                {
                    Errors = errors
                };

                context.Result = new BadRequestObjectResult(errorResponse);
            }
        }

        public void OnActionExecuting(ActionExecutingContext context) 
        {
            if(!context.ModelState.IsValid)
            {
                var errors = context.ModelState
                    .Where(x => x.Value != null && x.Value.Errors.Any())
                    .ToDictionary(
                        kvp => kvp.Key.ToLower(),
                        kvp => kvp.Value?.Errors?
                            .Where(error => error != null)
                            .Select(error => error.ErrorMessage)
                            .ToArray() ?? Array.Empty<string>()
                    );

                var errorResponse = new ErrorResponse
                {
                    Errors = errors
                };

                context.Result = new BadRequestObjectResult(errorResponse);
            }
        }
    }
}
