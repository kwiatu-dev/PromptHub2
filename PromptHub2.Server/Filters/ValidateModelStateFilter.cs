using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Validations
{
    public class ValidateModelStateFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext actionExecutedContext) 
        { }

        public void OnActionExecuting(ActionExecutingContext actionExecutingContext) 
        {
            if(!actionExecutingContext.ModelState.IsValid)
            {
                var messages = actionExecutingContext.ModelState
                    .SelectMany(message => message.Value.Errors)
                    .Select(error => error.ErrorMessage)
                    .ToList();

                actionExecutingContext.Result = new BadRequestObjectResult(
                    new FailedResponse
                    {
                        Status = "Error",
                        Message = "Wystąpił jeden lub więcej błędów podczas walidacji.",
                        Errors = messages
                    });
            }
        }
    }
}
