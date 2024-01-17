using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Models.Requests
{
    public class EditPromptRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string ?Model { get; set; }
        public uint Tokens { get; set; }
        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
