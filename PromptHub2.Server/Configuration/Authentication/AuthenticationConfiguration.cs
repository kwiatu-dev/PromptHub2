using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using PromptHub2.Server.Middlewares;
using PromptHub2.Server.Models.Responses;
using System.Security.Claims;
using System.Text;

namespace PromptHub2.Server.Configuration.Authentication
{
    public static class AuthenticationConfiguration
    {
        public static void AddAuthenticationConfiguration(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidAudience = configuration["JWT:ValidAudience"],
                    ValidIssuer = configuration["JWT:ValidIssuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"] ?? ""))
                };

                options.Events = new JwtBearerEvents
                {
                    OnChallenge = JwtBearerEventHandlers.OnChallenge,
                };
            });
        }
    }
}
