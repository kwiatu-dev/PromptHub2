using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Data.Seed
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder builder)
        {
            var roles = new List<IdentityRole>() {
                new() { Id = Guid.NewGuid().ToString(), Name = Roles.Administrator }
            };

            builder.Entity<IdentityRole>().HasData(roles);

            var administrator = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "fi.kwiatkowski@gmail.com",
                Email = "fi.kwiatkowski@gmail.com",
                NormalizedEmail = "FI.KWIATKOWSKI@GMAIL.COM",
                NormalizedUserName = "FI.KWIATKOWSKI@GMAIL.COM",
                EmailConfirmed = true,
            };

            administrator.PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(administrator, "Karteczka123!");

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
                prompts[i].ProjectId = projects[i % projects.Count].Id;
                prompts[i].CreatedById = projects[i % projects.Count].CreatedById;
                prompts[i].UpdatedById = projects[i % projects.Count].UpdatedById;
            }

            builder.Entity<Prompt>().HasData(prompts);
            builder.Entity<Project>().HasData(projects);
        }
    }
}
