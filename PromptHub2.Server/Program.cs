using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Data;
using PromptHub2.Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<SoftDeleteInterceptor>();
builder.Services.AddSingleton<AuditableEntitiesInterceptor>();

builder.Services.AddDbContext<AppDbContext>((serviceProvider, options) =>
{
    var interceptorSoftDeletes = serviceProvider
        .GetRequiredService<SoftDeleteInterceptor>();

    var interceptorAuditableEntities = serviceProvider
          .GetRequiredService<AuditableEntitiesInterceptor>();

    string connectionString = builder.Configuration.GetConnectionString("PromptHub") ?? "Data Source=Default.db";

    options.UseSqlite(connectionString)
        .AddInterceptors(interceptorSoftDeletes)
        .AddInterceptors(interceptorAuditableEntities);
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
}).AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
