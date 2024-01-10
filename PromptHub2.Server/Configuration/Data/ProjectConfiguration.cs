using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Configuration.Data
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasQueryFilter(project => project.IsDeleted == false);
        }
    }
}
