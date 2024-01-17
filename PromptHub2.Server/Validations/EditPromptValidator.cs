using Bogus;
using FluentValidation;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Validations
{
    public class EditPromptValidator : AbstractValidator<EditPromptRequest>
    {
        private readonly IProjectRepository _projectRepository;
        public EditPromptValidator(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;

            RuleFor(x => x.Name)
                    .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "name"))
                    .MinimumLength(10).WithMessage(string.Format(ValidationErrors.MinimumLengthText, 10))
                    .MaximumLength(128).WithMessage(string.Format(ValidationErrors.MaximumLengthText, 128));

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "description"))
                .MinimumLength(10).WithMessage(string.Format(ValidationErrors.MinimumLengthText, 10))
                .MaximumLength(256).WithMessage(string.Format(ValidationErrors.MaximumLengthText, 256));

            RuleFor(x => x.Model)
                .Must(x => x == null || LM.Models.Contains(x)).WithMessage(string.Format(ValidationErrors.InvalidField, "models"));

            RuleFor(x => x.Messages)
                .ForEach(message =>
                {
                    message.Must(m => LM.Roles.Contains(m.Role)).WithMessage(string.Format(ValidationErrors.InvalidField, "role"));
                    message.Must(m => !string.IsNullOrWhiteSpace(m.Content)).WithMessage(string.Format(ValidationErrors.EmptyField, "content"));
                });

        }
    }
}
