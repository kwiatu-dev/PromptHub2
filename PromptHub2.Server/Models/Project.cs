using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PromptHub2.Server.Models
{
    public class Project : ISoftDeleteEntity, IAuditableEntity
    {
        [Key]
        public string? Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string? Name { get; set; }

        [MaxLength(256)]
        public string? Description { get; set; }

        public ICollection<Prompt>? Prompts { get; set; }

        [Required]
        public DateTime? CreatedAt { get; set; }

        [Required]
        [ForeignKey("IdentityUser")]
        public string? CreatedById { get; set; }

        [JsonIgnore]
        public virtual IdentityUser? CreatedBy { get; set; }

        [Required]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        [ForeignKey("IdentityUser")]
        public string? UpdatedById { get; set; }

        [JsonIgnore]
        public virtual IdentityUser? UpdatedBy { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
