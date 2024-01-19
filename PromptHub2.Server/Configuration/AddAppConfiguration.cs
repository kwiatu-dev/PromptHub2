using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Models.Settings;

namespace PromptHub2.Server.Configuration
{
    public static class AppConfiguration
    {
        public static void AddAppConfiguration(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<MailSettings>(configuration.GetSection("MailSettings"));
            services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
        }
    }
}
