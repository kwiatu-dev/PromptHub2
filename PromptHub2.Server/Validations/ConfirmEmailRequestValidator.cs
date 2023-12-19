using FluentValidation;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Validations
{
    public class ConfirmEmailRequestValidator : AbstractValidator<ConfirmEmailRequest>
    {
        public ConfirmEmailRequestValidator() 
        {
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Niepoprawny format adresu e-mail.");

            RuleFor(x => x.Token)
                .NotEmpty().WithMessage("Token nie został wprowadzony.");
        }
    }
}
