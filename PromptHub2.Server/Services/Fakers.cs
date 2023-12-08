using Bogus;
using Bogus.Extensions;
using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Infrastructure;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Services
{
    public class Fakers
    {
        public static Faker<IdentityUser> GetUserGenerator()
        {
            var userFaker = new Faker<IdentityUser>()
                .RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.UserName, f => f.Internet.Email())
                .RuleFor(u => u.Email, (f, u) => u.UserName)
                .RuleFor(u => u.EmailConfirmed, f => f.Random.Bool())
                .RuleFor(u => u.PasswordHash, (f, u) => new PasswordHasher<IdentityUser>().HashPassword(u, "Password@1"));

            return userFaker;
        }

        public static Faker<Prompt> GetPromptGenerator()
        {
            var roles = new[] { "user", "system", "assistant" };
            var models = new[] { "gpt-3.5-trubo", "gpt-4" };

            var messageFaker = new Faker<Message>()
                .RuleFor(m => m.Role, f => f.Random.ArrayElement(roles))
                .RuleFor(m => m.Content, f => f.Lorem.Paragraph().ClampLength(16, 64));

            var promptFaker = new Faker<Prompt>()
                .RuleFor(p => p.Id, f => Guid.NewGuid().ToString())
                .RuleFor(p => p.Name, f => f.Lorem.Paragraph().ClampLength(10, 128))
                .RuleFor(p => p.Description, f => f.Lorem.Paragraph().ClampLength(50, 256))
                .RuleFor(p => p.Messages, f => messageFaker.Generate(f.Random.Int(1, 10)).ToList())
                .RuleFor(p => p.Model, f => f.Random.ArrayElement(models))
                .RuleFor(p => p.Tokens, f => f.Random.Int(13, 16000))
                .RuleFor(p => p.CreatedAt, f => f.Date.Between(new DateTime(2022, 1, 1), new DateTime(2023, 12, 31)))
                .RuleFor(p => p.UpdatedAt, (f, p) => p.CreatedAt)
                .RuleFor(p => p.IsDeleted, f => f.Random.Bool());

            return promptFaker;
        }

        public static Faker<Project> GetProjectGenerator(List<IdentityUser> users)
        {
            var projectFaker = new Faker<Project>()
                .RuleFor(p => p.Id, f => Guid.NewGuid().ToString())
                .RuleFor(p => p.Name, f => f.Lorem.Paragraph().ClampLength(10, 128))
                .RuleFor(p => p.Description, f => f.Lorem.Paragraph().ClampLength(50, 256))
                .RuleFor(p => p.CreatedById, f => f.Random.ListItem(users).Id)
                .RuleFor(p => p.UpdatedById, (f, u) => u.CreatedById)
                .RuleFor(p => p.CreatedAt, f => f.Date.Between(new DateTime(2022, 1, 1), new DateTime(2023, 12, 31)))
                .RuleFor(p => p.UpdatedAt, (f, p) => p.CreatedAt)
                .RuleFor(p => p.IsDeleted, f => f.Random.Bool());

            return projectFaker;
        }
    }
}
