using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PromptHub2.Server.Models.Entites
{
    public class Project : ISoftDeleteEntity, IAuditableEntity
    {
        [Key]
        public string Id { get; set; } = string.Empty;

        [Required]
        [MaxLength(128)]
        public string? Name { get; set; }

        [MaxLength(256)]
        public string? Description { get; set; }

        public ICollection<Prompt> Prompts { get; set; } = new Collection<Prompt>();

        [Required]
        public DateTime? CreatedAt { get; set; }

        [Required]
        [ForeignKey("User")]
        public string? CreatedById { get; set; }

        [JsonIgnore]
        public virtual User? CreatedBy { get; set; }

        [Required]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [ForeignKey("User")]
        public string? UpdatedById { get; set; }

        [JsonIgnore]
        public virtual User? UpdatedBy { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
