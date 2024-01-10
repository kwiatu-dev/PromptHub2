using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Interfaces
{
    public interface IProjectService
    {
        Task<List<Project>> GetAllProjectsAsync();
        Task<Project> GetProjectByIdAsync(string guid);
        Task<Project?> CreateProjectAsync(CreateProjectRequest request);
        Task<Project> UpdateProjectAsync(string guid, Project request);
        Task<Project> DeleteProjectAsync(string guid);

    }
}
