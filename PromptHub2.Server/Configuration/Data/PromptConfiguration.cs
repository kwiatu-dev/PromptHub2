using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PromptHub2.Server.Models.Entites;
using System.Text.Json;

namespace PromptHub2.Server.Configuration.Data
{
    public class PromptConfiguration : IEntityTypeConfiguration<Prompt>
    {
        public void Configure(EntityTypeBuilder<Prompt> builder)
        {
            builder.HasQueryFilter(prompt => prompt.IsDeleted == false);

            builder.Property(prompt => prompt.Messages)
                .HasConversion(
                    v => v == null ? null : JsonSerializer.Serialize(v, new JsonSerializerOptions()),
                    v => v == null ? new List<Message>() : JsonSerializer.Deserialize<List<Message>>(v, new JsonSerializerOptions()) ?? new List<Message>())
            .Metadata.SetValueComparer(new ValueComparer<List<Message>>(
                (c1, c2) => (c1 == null && c2 == null) || (c1 != null && c2 != null && c1.SequenceEqual(c2)),
                c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
                c => (List<Message>)c.ToList()));
        }
    }
}
