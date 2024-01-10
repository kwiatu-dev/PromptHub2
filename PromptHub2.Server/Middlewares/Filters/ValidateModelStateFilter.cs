using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PromptHub2.Server.Models.Responses;


namespace PromptHub2.Server.Middlewares.Filters
{
    public class ValidateModelStateFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(new ErrorResponse
                {
                    Errors = Helpers.ExtractErrors.FromModelState(context.ModelState)
                });
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(new ErrorResponse
                {
                    Errors = Helpers.ExtractErrors.FromModelState(context.ModelState)
                });
            }
        }
    }
}
