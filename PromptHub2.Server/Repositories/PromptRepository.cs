using Microsoft.EntityFrameworkCore;
using PromptHub2.Server.Data;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Repositories
{
    public class PromptRepository : IPromptRepository
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _dbContext;

        public PromptRepository(
            IUserService userService,
            AppDbContext dbContext)
        {
            _userService = userService;
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

            return new List<Prompt>();
        }

        public async Task<Prompt?> GetByIdAsync(string uuid)
        {
            var user = await _userService.GetAuthenticatedUserAsync();

            if (user != null)
            {
                return await _dbContext.Prompts
                    .AsNoTracking()
                    .Where(p => p.CreatedById == user.Id && p.Id == uuid)
                    .FirstOrDefaultAsync();
            }

            return null;
        }

        public async Task<Prompt?> CreateAsync(CreatePromptRequest request)
        {
            var user = await _userService.GetAuthenticatedUserAsync();

            if (user != null)
            {
                Prompt prompt = new()
                {
                    Id = Guid.NewGuid().ToString(),
                    ProjectId = request.ProjectId,
                    Name = request.Name,
                    Description = request.Description,
                    CreatedById = user.Id,
                    UpdatedById = user.Id,
                };

                var promptEntry = _dbContext.Prompts.Add(prompt);

                return promptEntry.Entity;
            }

            return null;
        }

        public async Task<Prompt?> UpdateAsync(string guid, EditPromptRequest request)
        {
            var prompt = await GetByIdAsync(guid);

            if (prompt != null)
            {
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
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
    }
}


