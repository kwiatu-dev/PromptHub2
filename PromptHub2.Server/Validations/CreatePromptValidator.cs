using FluentValidation;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Validations.Extensions;

namespace PromptHub2.Server.Validations
{
    public class CreatePromptValidator : AbstractValidator<CreatePromptRequest>
    {
        private readonly IProjectRepository _projectRepository;
        public CreatePromptValidator(IProjectRepository projectRepository) 
        {
            _projectRepository = projectRepository;

            RuleFor(x => x.ProjectId)
                .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "projectId"))
                .ValidGuid()
                .MustAsync(ProjectExistValidator).WithMessage(string.Format(ValidationErrors.EntityNotExist, "project"));

            RuleFor(x => x.Name)
                    .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "name"))
                    .MinimumLength(10).WithMessage(string.Format(ValidationErrors.MinimumLengthText, 10))
                    .MaximumLength(128).WithMessage(string.Format(ValidationErrors.MaximumLengthText, 128));

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "description"))
                .MinimumLength(10).WithMessage(string.Format(ValidationErrors.MinimumLengthText, 10))
                .MaximumLength(256).WithMessage(string.Format(ValidationErrors.MaximumLengthText, 256));
        }

        private async Task<bool> ProjectExistValidator(string? projectId, CancellationToken cancellationToken)
        {
            if(projectId != null)
            {
                var project = await _projectRepository.GetByIdAsync(projectId);

                return project != null;
            }

            return false;
        }
    }
}
