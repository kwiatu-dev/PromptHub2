using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Data;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Repositories
{
    public class ProjectRepository : IProjectService
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _dbContext;

        public ProjectRepository(
            IUserService userService,
            AppDbContext dbContext)
        {
            _userService = userService;
            _dbContext = dbContext;
        }

        public async Task<List<Project>> GetAllProjectsAsync()
        {
            var user = await _userService.GetCurrentUserAsync();

            if (user != null)
            {
                return await _dbContext.Projects
                    .Where(p => p.CreatedById == user.Id)
                    .Include(p => p.Prompts)
                    .ToListAsync();
            }

            return new List<Project>();
        }

        public async Task<Project?> CreateProjectAsync(CreateProjectRequest request)
        {
            var user = await _userService.GetCurrentUserAsync();

            if (user != null)
            {
                Project newProject = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = request.Name,
                    Description = request.Description,
                    CreatedById = user.Id,
                    UpdatedById = user.Id,
                };

                var projectEntry = _dbContext.Projects.Add(newProject);
                await _dbContext.SaveChangesAsync();

                return projectEntry.Entity;
            }

            return null;
        }

        Task<Project> IProjectService.DeleteProjectAsync(string guid)
        {
            throw new NotImplementedException();
        }

        Task<Project> IProjectService.GetProjectByIdAsync(string guid)
        {
            throw new NotImplementedException();
        }

        Task<Project> IProjectService.UpdateProjectAsync(string guid, Project request)
        {
            throw new NotImplementedException();
        }
    }
}
