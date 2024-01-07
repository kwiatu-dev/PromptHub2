using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Responses;
using System.Security.Claims;

namespace PromptHub2.Server.Controllers
{
    [Authorize]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly UserManager<IdentityUser> _userManager;
        public ProjectController(
            IProjectService projectService, 
            UserManager<IdentityUser> userManager) 
        {
            _projectService = projectService;
            _userManager = userManager;
        }

        [Route("/projects")]
        [HttpGet]
        public async Task<ActionResult<List<Project>>> GetAllProjects()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = await _userManager.FindByIdAsync(userId ?? "");

            if (user != null)
            {
                return await _projectService.GetAllProjectsAsync(user);
            }

            return BadRequest(new ErrorResponse {
                Message = Errors.UserNotExistOrUnauthorized,
            });
        }
    }
}
