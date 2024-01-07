using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Data;

namespace PromptHub2.Server.Configuration.Data
{
    public static class DbContextConfiguration
    {
        public static void AddDbContextConfiguration(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>((serviceProvider, options) =>
            {
                var interceptorSoftDeletes = serviceProvider
                    .GetRequiredService<SoftDeleteInterceptor>();

                var interceptorAuditableEntities = serviceProvider
                    .GetRequiredService<AuditableEntitiesInterceptor>();

                string connectionString = configuration.GetConnectionString("PromptHub") ?? "Data Source=Default.db";

                options.UseSqlite(connectionString)
                    .EnableSensitiveDataLogging()
                    .AddInterceptors(interceptorSoftDeletes)
                    .AddInterceptors(interceptorAuditableEntities);
            });
        }
    }
}
