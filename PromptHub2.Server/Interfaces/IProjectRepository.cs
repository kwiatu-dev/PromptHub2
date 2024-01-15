using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project?> GetByIdAsync(string uuid);
        Task<Project?> CreateAsync(CreateProjectRequest request);
        Task<Project?> UpdateAsync(string uuid, EditProjectRequest request);
        Task<bool> DeleteAsync(string uuid);

    }
}
