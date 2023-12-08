using Bogus.DataSets;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Infrastructure;
using PromptHub2.Server.Models;
using PromptHub2.Server.Services;
using System.Runtime.CompilerServices;

namespace PromptHub2.Server.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ModelBuilder builder)
        {
            var roles = new List<IdentityRole>() { 
                new IdentityRole { Id = Guid.NewGuid().ToString(), Name = Roles.Administrator }
            };

            builder.Entity<IdentityRole>().HasData(roles);

            var administrator = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "fi.kwiatkowski@gmail.com",
                Email = "fi.kwiatkowski@gmail.com",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Karteczka123!"),
            };

            var users = Fakers.GetUserGenerator().Generate(10);
            users.Add(administrator);

            builder.Entity<IdentityUser>().HasData(users);

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = roles[0].Id,
                    UserId = administrator.Id,
                }
            );

            var projects = Fakers.GetProjectGenerator(users).Generate(10);
            var prompts = Fakers.GetPromptGenerator().Generate(30);

            for (int i = 0; i < prompts.Count; i++)
            {
                prompts[i].Project = projects[i % projects.Count];
            }

            foreach (var project in projects)
            {
                project.Prompts = prompts.Where(p => p.Project == project).ToList();

                foreach (var prompt in project.Prompts)
                {
                    prompt.CreatedBy = project.CreatedBy;
                    prompt.UpdatedBy = project.UpdatedBy;
                }
            }

            builder.Entity<Prompt>().HasData(prompts);
            builder.Entity<Project>().HasData(projects);
        }
    }
}
