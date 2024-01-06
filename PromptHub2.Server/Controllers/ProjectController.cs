using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Models;
using PromptHub2.Server.Services;
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

            if(userId != null)
            {
                var user = await _userManager.FindByIdAsync(userId);

                if(user != null)
                {
                    return await _projectService.GetAllProjectsAsync(user);
                }
            }

            return Unauthorized(
                new ErrorResponse
                {
                    Message = "Użytkownik nie istnieje lub nie ma dostępu do zasobu.",
                });
        }
    }
}
