using FluentValidation;
using FluentValidation.AspNetCore;
using PromptHub2.Server.Common;
using PromptHub2.Server.Constants;
using System.Security.Claims;

namespace PromptHub2.Server.Configuration.Extensions
{
    public static class AuthorizationConfiguration
    {
        public static void AddExtensionsConfiguration(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddFluentValidationAutoValidation()
                .AddValidatorsFromAssemblyContaining<IAssemblyMarker>();
        }
    }
}
