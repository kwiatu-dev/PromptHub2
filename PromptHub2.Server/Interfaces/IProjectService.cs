﻿using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Models.Entites;

namespace PromptHub2.Server.Interfaces
{
    public interface IProjectService
    {
        Task<List<Project>> GetAllProjectsAsync(IdentityUser user);
        Task<List<Project>> GetProjectByIdAsync(string guid);
        Task<List<Project>> AddProjectAsync(Project project);
        Task<Project> UpdateProjectAsync(string guid, Project request);
        Task<Project> DeleteProjectAsync(string guid);

    }
}