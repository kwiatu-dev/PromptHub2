using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using System.Linq.Expressions;

namespace PromptHub2.Server.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Prompt> Prompts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Prompt>()
                .OwnsMany(prompt => prompt.Messages, builder => { builder.ToJson(); })
                .HasQueryFilter(prompt => prompt.IsDeleted == false);

            modelBuilder.Entity<Project>()
                .HasQueryFilter(project => project.IsDeleted == false);
        }
    }
}
