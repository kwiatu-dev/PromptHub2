using FluentValidation;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Validations
{
    public class ForgotPasswordRequestValidator : AbstractValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordRequestValidator() 
        {
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Niepoprawny format adresu e-mail.")
                .EmailAddress().WithMessage("Niepoprawny format adresu e-mail.");
        }
    }
}
