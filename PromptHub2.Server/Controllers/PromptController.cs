using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
    public class PromptController : ControllerBase
    {
        private readonly IPromptRepository _promptRepository;
        public PromptController(IPromptRepository promptRepository) 
        {
            _promptRepository = promptRepository;
        }

        [HttpGet]
        [Route("/projects/{guid}/prompts")]
        public async Task<ActionResult> GetAll(string guid)
        {
            return Ok(await _promptRepository.GetAllAsync(guid));
        }

        [HttpGet]
        [Route("/prompts/{guid}")]
        public async Task<ActionResult> GetById(string guid)
        {
            var prompt = await _promptRepository.GetByIdAsync(guid);

            if(prompt != null)
            {
                return Ok(prompt);
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Prompt))
            });
        }

        [HttpPost]
        [Route("/projects/{guid}/prompts")]
        public async Task<ActionResult> Create(string guid, CreatePromptRequest request)
        {
            var prompt = await _promptRepository.CreateAsync(guid, request);

            if(prompt != null)
            {
                return Ok(prompt);
            }

            return BadRequest(new ErrorResponse());
        }

        [HttpPut]
        [Route("/prompts/{guid}")]
        public async Task<ActionResult> Update(string guid, EditPromptRequest request)
        {
            var prompt = await _promptRepository.UpdateAsync(guid, request);

            if(prompt != null)
            {
                return Ok(prompt);
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Prompt))
            });
        }

        [HttpDelete]
        [Route("/prompts/{guid}")]
        public async Task<ActionResult> Delete(string guid)
        {
            var result = await _promptRepository.DeleteAsync(guid);

            if (result)
            {
                return Ok(result);
            }

            return NotFound(new ErrorResponse
            {
                Message = string.Format(Errors.EntityNotFound, nameof(Prompt))
            });
        }
    }
}
