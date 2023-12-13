using Microsoft.AspNetCore.Authorization.Policy;
using Microsoft.AspNetCore.Authorization;
using PromptHub2.Server.Models;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Linq;

namespace PromptHub2.Server.Services
{
    public class SampleAuthorizationMiddlewareResultHandler : IAuthorizationMiddlewareResultHandler
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
                            "authorization", 
                            authorizeResult.AuthorizationFailure?.FailedRequirements
                                .Select(failedRequirement =>
                                {
                                    if (failedRequirement is RolesAuthorizationRequirement rolesRequirement)
                                    {
                                        return $"Użytkownik nie posiada następujących uprawnień: {string.Join(", ", rolesRequirement.AllowedRoles)}";
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

    public class Show404Requirement : IAuthorizationRequirement { }
}
