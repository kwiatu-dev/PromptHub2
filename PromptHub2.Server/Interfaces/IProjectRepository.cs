using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project?> GetByIdAsync(string guid);
        Task<Project?> CreateAsync(CreateProjectRequest request);
        Task<Project?> UpdateAsync(string guid, EditProjectRequest request);
        Task<bool> DeleteAsync(string guid);

    }
}
