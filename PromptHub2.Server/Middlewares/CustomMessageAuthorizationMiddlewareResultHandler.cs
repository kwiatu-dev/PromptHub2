using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Authorization;
using PromptHub2.Server.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Linq;
using PromptHub2.Server.Models.Responses;
using PromptHub2.Server.Constants;

namespace PromptHub2.Server.Middlewares
{
    public class CustomMessageAuthorizationMiddlewareResultHandler : IAuthorizationMiddlewareResultHandler
    {
        private readonly AuthorizationMiddlewareResultHandler defaultHandler = new();

        public async Task HandleAsync(
            RequestDelegate next,
            HttpContext context,
            AuthorizationPolicy policy,
            PolicyAuthorizationResult authorizeResult)
        {
            if (authorizeResult.Forbidden
                && authorizeResult.AuthorizationFailure != null
                && authorizeResult.AuthorizationFailure.FailedRequirements.Any())
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;

                await context.Response.WriteAsJsonAsync(new ErrorResponse
                {
                    Errors = new Dictionary<string, string[]>
                    {
                        {
                            "submit",
                            authorizeResult.AuthorizationFailure?.FailedRequirements
                                .Select(failedRequirement =>
                                {
                                    if (failedRequirement is RolesAuthorizationRequirement rolesRequirement)
                                    {
                                        return $"{Errors.UserDoesNotHaveRights} {string.Join(", ", rolesRequirement.AllowedRoles)}";
                                    }

                                    return failedRequirement.GetType().Name;
                                })
                                .ToArray() ?? Array.Empty<string>()
                        }
                    }
                });

                return;
            }

            await defaultHandler.HandleAsync(next, context, policy, authorizeResult);
        }
    }

    //public class Show404Requirement : IAuthorizationRequirement { }
}
