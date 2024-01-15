using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
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
        private readonly IProjectRepository _projectRepository;

        public ProjectController(
            IProjectRepository projectService) 
        {
            _projectRepository = projectService;
        }

        [Route("/projects")]
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAll()
        {
            return await _projectRepository.GetAllAsync();
        }

        [Route("/projects")]
        [HttpPost]
        public async Task<ActionResult<Project>> Create(CreateProjectRequest request)
        {
            var result = await _projectRepository.CreateAsync(request);

            if(result != null)
            {
                return Created(nameof(GetById), result);
            }

            return BadRequest(new ErrorResponse());
        }

        [Route("/projects/{uuid}")]
        [HttpDelete]
        public async Task<ActionResult> Delete(string uuid)
        {
            var result = await _projectRepository.DeleteAsync(uuid);

            if(result == true)
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

        [Route("/projects/{uuid}")]
        [HttpGet]
        public async Task<ActionResult> GetById(string uuid)
        {
            var result = await _projectRepository.GetByIdAsync(uuid);

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Project))
            });
        }

        [Route("/projects/{uuid}")]
        [HttpPut]
        public async Task<ActionResult> Update(string uuid, EditProjectRequest request)
        {
            var result = await _projectRepository.UpdateAsync(uuid, request);

            if(result != null)
            {
                return Ok(result);
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Project))
            });
        }
    }
}
