using PromptHub2.Server.Constants;
using System.Security.Claims;

namespace PromptHub2.Server.Configuration.Authorization
{
    public static class AuthorizationConfiguration
    {
        public static void AddAuthorizationConfiguration(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy(Roles.AdminPolicy,
                    policy => policy.RequireClaim(ClaimTypes.Role, Roles.Administrator));
            });

            services.AddAntiforgery(options => options.HeaderName = "X-XSRF-TOKEN");
        }
    }
}
