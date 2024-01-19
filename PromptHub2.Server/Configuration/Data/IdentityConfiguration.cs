using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Data;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Configuration.Data
{
    public static class IdentityConfiguration
    {
        public static void AddIdentityConfiguration(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireNonAlphanumeric = true;

                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);

                options.User.RequireUniqueEmail = true;

                options.SignIn.RequireConfirmedEmail = true;
            })
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();
        }
    }
}
