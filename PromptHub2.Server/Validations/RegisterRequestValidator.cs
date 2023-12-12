using FluentValidation;
using Microsoft.AspNetCore.Identity;
using PromptHub2.Server.Models;

namespace PromptHub2.Server.Validations
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
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
        }
    }
}
