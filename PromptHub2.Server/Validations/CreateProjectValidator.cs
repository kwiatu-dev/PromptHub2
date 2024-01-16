using FluentValidation;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Requests;

namespace PromptHub2.Server.Validations
{
    public class CreateProjectValidator : AbstractValidator<CreateProjectRequest>
    {
        public CreateProjectValidator() 
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "name"))
                .MinimumLength(10).WithMessage(string.Format(ValidationErrors.MinimumLengthText, 10))
                .MaximumLength(128).WithMessage(string.Format(ValidationErrors.MaximumLengthText, 128));

            RuleFor(x => x.Description)
                .NotEmpty().WithMessage(string.Format(ValidationErrors.EmptyField, "description"))
                .MinimumLength(10).WithMessage(string.Format(ValidationErrors.MinimumLengthText, 10))
                .MaximumLength(256).WithMessage(string.Format(ValidationErrors.MaximumLengthText, 256));
        }
    }
}
