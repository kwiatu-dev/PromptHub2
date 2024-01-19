using Microsoft.VisualBasic;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Models.Entites.Extensions
{
    public static class EntityExtension
    {
        public static ProjectResponse? GenerateResponse(this Project project, bool includePrompts = false)
        {
            if (project != null)
            {
                return new ProjectResponse(
                    project.Id,
                    project.Name,
                    project.Description,
                    includePrompts ? project.Prompts : null,
                    project.Prompts != null ? project.Prompts.Count : 0,
                    project.CreatedAt?.ToString(Date.DateFormat),
                    project.UpdatedAt?.ToString(Date.DateFormat) ?? string.Empty,
                    project.DeletedAt?.ToString(Date.DateFormat) ?? string.Empty);
            }

            return null;
        }

        public static List<ProjectResponse?> GenerateResponse(this List<Project> projects, bool includePrompts = false)
        {
            if (projects != null)
            {
                return projects.Select(p => p.GenerateResponse(includePrompts)).ToList();
            }

            return new();
        }

        public static PromptResponse? GenerateResponse(this Prompt prompt, bool includeMessages = true)
        {
            if (prompt != null)
            {
                return new PromptResponse(
                    prompt.Id,
                    prompt.ProjectId,
                    prompt.Name,
                    prompt.Description,
                    prompt.Model,
                    prompt.Tokens,
                    includeMessages ? prompt.Messages : null,
                    prompt.Messages.Count,
                    prompt.CreatedAt?.ToString(Date.DateFormat),
                    prompt.UpdatedAt?.ToString(Date.DateFormat) ?? string.Empty,
                    prompt.DeletedAt?.ToString(Date.DateFormat) ?? string.Empty);
            }

            return null;
        }

        public static List<PromptResponse?> GenerateResponse(this List<Prompt> prompts, bool includeMessages = false)
        {
            if (prompts != null)
            {
                return prompts.Select(p => p.GenerateResponse(includeMessages)).ToList();
            }

            return new();
        }

        public static UserResponse? GenerateResponse(this User? user) 
        {
            if (user != null)
            {
                return new UserResponse(
                    user.Id,
                    user.Email ?? "");
            }

            return null;
        }
    }
}
