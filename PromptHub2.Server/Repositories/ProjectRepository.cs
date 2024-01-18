using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Data;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;
using System;

namespace PromptHub2.Server.Repositories
{
    public class ProjectRepository : IProjectRepository
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

        public async Task<List<Project>> GetAllAsync()
        {
            var user = await _userService.GetAuthenticatedUserAsync();

            if (user != null)
            {
                return await _dbContext.Projects
                    .AsNoTracking()
                    .Where(p => p.CreatedById == user.Id)
                    .Include(p => p.Prompts)
                    .ToListAsync();
            }

            return new();
        }

        public async Task<Project?> CreateAsync(CreateProjectRequest request)
        {
            var user = await _userService.GetAuthenticatedUserAsync();

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

        public async Task<bool> DeleteAsync(string guid)
        {
            var project = await GetByIdAsync(guid);

            if(project != null)
            {
                _dbContext.Remove(project);
                await _dbContext.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<Project?> GetByIdAsync(string guid)
        {
            var user = await _userService.GetAuthenticatedUserAsync();

            if (user != null)
            {
                return await _dbContext.Projects
                    .Where(p => p.Id == guid && p.CreatedById == user.Id)
                    .Include(p => p.Prompts)
                    .FirstOrDefaultAsync();
            }

            return null;
        }

        public async Task<Project?> UpdateAsync(string guid, EditProjectRequest request)
        {
            var project = await GetByIdAsync(guid);

            if (project != null) 
            {
                project.Name = request.Name;
                project.Description = request.Description;
                await _dbContext.SaveChangesAsync();

                return project;
            }

            return null;
        }
    }
}
