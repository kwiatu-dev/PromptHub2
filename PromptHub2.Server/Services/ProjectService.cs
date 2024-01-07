using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Data;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Services
{
    public class ProjectService : IProjectService
    {
        private readonly AppDbContext _context;

        public ProjectService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Project>> GetAllProjectsAsync(IdentityUser user)
        {
            var projects = await 
                _context.Projects
                    .Where(p => p.CreatedById == user.Id)
                    .Include(p => p.Prompts)
                    .ToListAsync();

            return projects;
        }

        Task<List<Project>> IProjectService.AddProjectAsync(Project project)
        {
            throw new NotImplementedException();
        }

        Task<Project> IProjectService.DeleteProjectAsync(string guid)
        {
            throw new NotImplementedException();
        }

        Task<List<Project>> IProjectService.GetProjectByIdAsync(string guid)
        {
            throw new NotImplementedException();
        }

        Task<Project> IProjectService.UpdateProjectAsync(string guid, Project request)
        {
            throw new NotImplementedException();
        }
    }
}
