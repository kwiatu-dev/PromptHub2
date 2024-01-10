using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Controllers
{
    [Authorize]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        public ProjectController(
            IProjectService projectService) 
        {
            _projectService = projectService;
        }

        [Route("/projects")]
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            return await _projectService.GetAllProjectsAsync();
        }

        [Route("/projects")]
        [HttpPost]
        public async Task<ActionResult<Project>> CreateProject(CreateProjectRequest request)
        {
            var result = await _projectService.CreateProjectAsync(request);

            if(result != null)
            {
                return Created(nameof(GetAllProjects), result);
            }

            return BadRequest(new ErrorResponse());
        }
    }
}
