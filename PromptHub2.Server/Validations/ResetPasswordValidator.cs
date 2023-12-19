using FluentValidation;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Validations
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordRequest>
    {
        public ResetPasswordValidator() 
        {
            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("Niepoprawny format adresu e-mail.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Hasło jest wymagane.")
                .MinimumLength(8).WithMessage("Hasło musi mieć co najmniej 8 znaków.")
                .Matches("[A-Z]").WithMessage("Hasło musi zawierać co najmniej jedną wielką literę.")
                .Matches("[a-z]").WithMessage("Hasło musi zawierać co najmniej jedną małą literę.")
                .Matches("[0-9]").WithMessage("Hasło musi zawierać co najmniej jedną cyfrę.")
                .Matches("[^a-zA-Z0-9]").WithMessage("Hasło musi zawierać co najmniej jeden znak specjalny.");

            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Potwierdzenie hasła nie pasuje do hasła.");

            RuleFor(x => x.Token)
                .NotEmpty().WithMessage("Token nie został wprowadzony.");

        }
    }
}
