﻿using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Data;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Repositories
{
    public class PromptRepository : IPromptRepository
    {
        private readonly IUserService _userService;
        private readonly IProjectRepository _projectRepository;
        private readonly AppDbContext _dbContext;

        public PromptRepository(
            IUserService userService,
            IProjectRepository projectRepository,
            AppDbContext dbContext)
        {
            _userService = userService;
            _projectRepository = projectRepository;
            _dbContext = dbContext;
        }

        public async Task<List<Prompt>> GetAllAsync(string projectId)
        {
            var user = await _userService.GetAuthenticatedUserAsync();

            if (user != null)
            {
                return await _dbContext.Prompts
                    .AsNoTracking()
                    .Where(p => p.CreatedById == user.Id && p.ProjectId == projectId)
                    .ToListAsync();
            }

            return new();
        }

        public async Task<Prompt?> GetByIdAsync(string guid)
        {
            var user = await _userService.GetAuthenticatedUserAsync();

            if (user != null)
            {
                return await _dbContext.Prompts
                    .Where(p => p.CreatedById == user.Id && p.Id == guid)
                    .FirstOrDefaultAsync();
            }

            return null;
        }

        public async Task<Prompt?> CreateAsync(string projectId, CreatePromptRequest request)
        {
            var project = await _projectRepository.GetByIdAsync(projectId);

            if (project != null)
            {
                _dbContext.Entry(project).State = EntityState.Modified;

                Prompt prompt = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    ProjectId = projectId,
                    Name = request.Name,
                    Description = request.Description,
                    CreatedById = project.CreatedById,
                    UpdatedById = project.CreatedById,
                    Model = LM.DefaultModel
                };

                var promptEntry = _dbContext.Prompts.Add(prompt);

                await _dbContext.SaveChangesAsync();

                return promptEntry.Entity;
            }

            return null;
        }

        public async Task<Prompt?> UpdateAsync(string guid, EditPromptRequest request)
        {
            var prompt = await GetByIdAsync(guid);
            var project = await _projectRepository.GetByIdAsync(prompt?.ProjectId ?? "");

            if (prompt != null && project != null)
            {
                _dbContext.Entry(project).State = EntityState.Modified;

                prompt.Name = request.Name;
                prompt.Description = request.Description;
                prompt.Model = request.Model;
                prompt.Tokens = request.Tokens;
                prompt.Messages = request.Messages;

                await _dbContext.SaveChangesAsync();

                return prompt;
            }

            return null;
        }

        public async Task<bool> DeleteAsync(string guid)
        {
            var prompt = await GetByIdAsync(guid);
            var project = await _projectRepository.GetByIdAsync(prompt?.ProjectId ?? "");

            if (prompt != null && project != null)
            {
                _dbContext.Entry(project).State = EntityState.Modified;
                _dbContext.Prompts.Remove(prompt);

                await _dbContext.SaveChangesAsync();

                return true;
            }

            return false;
        }
    }
}


