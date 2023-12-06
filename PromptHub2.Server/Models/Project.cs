using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace PromptHub2.Server.Models
{
    public class Project : ISoftDeleteEntity, IAuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(256)]
        public string? Description { get; set; }
        public ICollection<Prompt>? Prompts { get; set; }

        [Required]
        public DateTime? CreatedAt { get; set; }

        [Required]
        public IdentityUser? CreatedBy { get; set; }

        [Required]
        public DateTime? UpdatedAt { get; set; }

        [Required]
        public IdentityUser? UpdatedBy { get; set; }

        [Required]
        public bool IsDeleted { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
