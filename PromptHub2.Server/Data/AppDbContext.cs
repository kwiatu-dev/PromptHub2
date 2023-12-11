using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PromptHub2.Server.Models;
using System.Text.Json;

namespace PromptHub2.Server.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Prompt> Prompts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prompt>()
                .HasQueryFilter(prompt => prompt.IsDeleted == false);

            modelBuilder.Entity<Project>()
                .HasQueryFilter(project => project.IsDeleted == false);

            modelBuilder.Entity<Prompt>()
                .Property(prompt => prompt.Messages)
                .HasConversion(
                    v => v == null ? null : JsonSerializer.Serialize(v, new JsonSerializerOptions()),
                    v => v == null ? new List<Message>() : JsonSerializer.Deserialize<List<Message>>(v, new JsonSerializerOptions()) ?? new List<Message>())
            .Metadata.SetValueComparer(new ValueComparer<List<Message>>(
                (c1, c2) => (c1 == null && c2 == null) || (c1 != null && c2 != null && c1.SequenceEqual(c2)),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => (List<Message>)c.ToList()));

            DbInitializer.Initialize(modelBuilder);
        }
    }
}
