using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Models.Settings;

namespace PromptHub2.Server.Configuration.Cookies
{
    public static class CookiesConfiguration
    {
        public static void AddCookiesConfiguration(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.Secure = CookieSecurePolicy.Always;
                options.MinimumSameSitePolicy = SameSiteMode.None;
                options.HttpOnly = Microsoft.AspNetCore.CookiePolicy.HttpOnlyPolicy.Always;
            });
        }
    }
}
