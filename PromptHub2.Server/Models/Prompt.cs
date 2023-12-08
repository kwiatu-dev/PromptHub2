using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PromptHub2.Server.Models
{
    public class Prompt : ISoftDeleteEntity, IAuditableEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string? Name { get; set; }

        [MaxLength(256)]
        public string? Description { get; set; }

        [Required]
        public List<Message> Messages { get; set; } = new List<Message>();

        [Required]
        [MaxLength(64)]
        public string? Model { get; set; }

        [Required]
        public int? Tokens { get; set; }

        [Required]
        [JsonIgnore]
        public Project? Project { get; set; }

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

    public class Message
    {
        public string? Role { get; set; }
        public string? Content { get; set; }

        public static implicit operator Message((string Role, string Content) values) =>
            new Message { Role = values.Role, Content = values.Content };

        public static implicit operator (string? Role, string? Content)(Message message) =>
            (message.Role, message.Content);
    }
}
