namespace PromptHub2.Server.Configuration.Cors
{
    public static class CorsConfiguration
    {
        public static IServiceCollection AddCorsConfiguration(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            return services.AddCors(options =>
            {
                options.AddPolicy(name: Constants.Cors.AllowClientCors, policy =>
                    {
                        policy.WithOrigins(configuration["Endpoints:Client"] ?? "")
                            .AllowAnyHeader()
                            .AllowAnyMethod()
                            .AllowCredentials();
                    });
            });
        }
    }
}
