using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PromptHub2.Server;
using PromptHub2.Server.Common;
using PromptHub2.Server.Data;
using PromptHub2.Server.Infrastructure;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Services;
using PromptHub2.Server.Validations;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

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
        .EnableSensitiveDataLogging()
        .AddInterceptors(interceptorSoftDeletes)
        .AddInterceptors(interceptorAuditableEntities);
});

builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
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
}).AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidateAudience = false,
        ValidAudience = configuration["JWT:ValidAudience"],
        ValidIssuer = configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"] ?? ""))
    };

    options.Events = new JwtBearerEvents
    {
        OnChallenge = async context =>
        {
            context.HandleResponse();

            context.Response.StatusCode = StatusCodes.Status403Forbidden;

            await context.Response.WriteAsJsonAsync(new ErrorResponse
            {
                Errors = new Dictionary<string, string[]> { 
                    { "authentication", new[] { "Odmowa dostêpu." } } 
                }
            });
        }
    };
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("AdminOnly",
        policy => policy.RequireClaim(ClaimTypes.Role, Roles.Administrator));
}).AddSingleton<IAuthorizationMiddlewareResultHandler, SampleAuthorizationMiddlewareResultHandler>();

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddFluentValidationAutoValidation()
    .AddValidatorsFromAssemblyContaining<IAssemblyMarker>();

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidateModelStateFilter>();
});

builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddTransient<IMailService, MailService>();

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

app.UseExceptionHandler("/error");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
