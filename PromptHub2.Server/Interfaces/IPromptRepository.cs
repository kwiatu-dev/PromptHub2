using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Interfaces
{
    public interface IPromptRepository
    {
        Task<Prompt?> CreateAsync(CreatePromptRequest request);
        Task<bool> DeleteAsync(string uuid);
        Task<List<Prompt>> GetAllAsync(string projectId);
        Task<Prompt?> GetByIdAsync(string uuid);
        Task<Prompt?> UpdateAsync(string uuid, EditPromptRequest request);
    }
}