using Microsoft.AspNetCore.Authentication.JwtBearer;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Middlewares
{
    public static class JwtBearerEventHandlers
    {
        public static Task OnChallenge(JwtBearerChallengeContext context)
        {
            context.HandleResponse();
            context.Response.StatusCode = StatusCodes.Status403Forbidden;

            return context.Response.WriteAsJsonAsync(new ErrorResponse
            {
                Errors = new Dictionary<string, string[]>
                {
                    { "submit", new[] { Errors.AccessDenied } }
                }
            });
        }
    }
}
