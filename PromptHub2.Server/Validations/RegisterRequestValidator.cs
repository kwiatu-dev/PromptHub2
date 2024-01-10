using FluentValidation;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Validations.Extensions;

namespace PromptHub2.Server.Validations
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.Email).ValidEmail();
            RuleFor(x => x.Password).ValidPassword();
        }
    }
}
