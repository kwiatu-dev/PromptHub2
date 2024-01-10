using FluentValidation;
using FluentValidation.AspNetCore;
using PromptHub2.Server.Common;

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
