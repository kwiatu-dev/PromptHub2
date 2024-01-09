using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PromptHub2.Server.Common;
using PromptHub2.Server.Data;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Middlewares;
using PromptHub2.Server.Middlewares.Filters;
using PromptHub2.Server.Models;
using PromptHub2.Server.Models.Responses;
using PromptHub2.Server.Models.Settings;
using PromptHub2.Server.Services;
using System.Security.Claims;
using System.Text;
using PromptHub2.Server.Constants;
using Microsoft.VisualBasic;
using PromptHub2.Server.Configuration.Cors;
using PromptHub2.Server.Configuration.Data;
using PromptHub2.Server.Configuration.Authorization;
using PromptHub2.Server.Configuration.Authentication;
using PromptHub2.Server.Configuration.Extensions;
using PromptHub2.Server.Configuration;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddSingleton<SoftDeleteInterceptor>();
builder.Services.AddSingleton<AuditableEntitiesInterceptor>();
builder.Services.AddSingleton<IAuthorizationMiddlewareResultHandler, ErrorHandlerAuthorizationMiddleware>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAuthenticateService, AuthenticateService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddTransient<IMailService, MailService>();

builder.Services.AddCorsConfiguration(configuration);
builder.Services.AddDbContextConfiguration(configuration);
builder.Services.AddIdentityConfiguration(configuration);
builder.Services.AddAuthenticationConfiguration(configuration);
builder.Services.AddAuthorizationConfiguration(configuration);
builder.Services.AddExtensionsConfiguration(configuration);
builder.Services.AddAppConfiguration(configuration);

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<ValidateModelStateFilter>();
    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(Cors.AllowClientCors);

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

app.Run();
