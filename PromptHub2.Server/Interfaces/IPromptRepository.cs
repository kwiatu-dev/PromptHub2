using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Interfaces
{
    public interface IPromptRepository
    {
        Task<List<Prompt>> GetAllAsync(string projectId);
        Task<Prompt?> GetByIdAsync(string guid);
        Task<Prompt?> CreateAsync(string projectId, CreatePromptRequest request);
        Task<Prompt?> UpdateAsync(string guid, EditPromptRequest request);
        Task<bool> DeleteAsync(string guid);
    }
}