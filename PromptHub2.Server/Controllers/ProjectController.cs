using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Entites.Extensions;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;

namespace PromptHub2.Server.Controllers
{
    [Authorize]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectController(
            IProjectRepository projectService) 
        {
            _projectRepository = projectService;
        }

        [Route("/projects")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok((await _projectRepository.GetAllAsync()).GenerateResponse());
        }

        [Route("/projects/{guid}")]
        [HttpGet]
        public async Task<ActionResult> GetById(string guid)
        {
            var project = await _projectRepository.GetByIdAsync(guid);

            if (project != null)
            {
                return Ok(project.GenerateResponse());
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Project))
            });
        }

        [Route("/projects")]
        [HttpPost]
        public async Task<ActionResult> Create(CreateProjectRequest request)
        {
            var project = await _projectRepository.CreateAsync(request);

            if(project != null)
            {
                return Created(nameof(GetById), project.GenerateResponse());
            }

            return BadRequest(new ErrorResponse());
        }

        [Route("/projects/{guid}")]
        [HttpPut]
        public async Task<ActionResult> Update(string guid, EditProjectRequest request)
        {
            var project = await _projectRepository.UpdateAsync(guid, request);

            if(project != null)
            {
                return Ok(project.GenerateResponse());
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Project))
            });
        }

        [Route("/projects/{guid}")]
        [HttpDelete]
        public async Task<ActionResult> Delete(string guid)
        {
            var result = await _projectRepository.DeleteAsync(guid);

            if (result == true)
            {
                return Ok(new SuccedResponse
                {
                    Message = string.Format(Messages.EntityDeleted, nameof(Project))
                });
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Project))
            });
        }
    }
}
