using FluentValidation;
using PromptHub2.Server.Constants;
using System.Linq.Expressions;

namespace PromptHub2.Server.Validations.Extensions
{
    public static class CommonRules
    {
        public static IRuleBuilder<T, string> ValidEmail<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage(ValidationErrors.EmailEmpty)
                .EmailAddress().WithMessage(ValidationErrors.IncorrectEmailFormat);
        }

        public static IRuleBuilder<T, string> ValidPassword<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage(ValidationErrors.PasswordEmpty)
                .MinimumLength(8).WithMessage(ValidationErrors.PasswordLength)
                .Matches("[A-Z]").WithMessage(ValidationErrors.PasswordCapitalLetter)
                .Matches("[a-z]").WithMessage(ValidationErrors.PasswordLowercaseLetter)
                .Matches("[0-9]").WithMessage(ValidationErrors.PasswordDigit)
                .Matches("[^a-zA-Z0-9]").WithMessage(ValidationErrors.PasswordSpecialCharacter);
        }

        public static IRuleBuilder<T, string> ValidToken<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder
                .NotEmpty().WithMessage(ValidationErrors.TokenNotProvided);
        }

        public static IRuleBuilder<T, string> ValidConfirmPassword<T>(
            this IRuleBuilder<T, string> ruleBuilder,
            Expression<Func<T, string>> passwordExpression
        ) where T : class
        {
            return ruleBuilder
                .NotEmpty().WithMessage(ValidationErrors.ConfirmPasswordEmpty)
                .Equal(passwordExpression).WithMessage(ValidationErrors.ConfirmPasswordNotMatch);
        }

        public static IRuleBuilder<T, string?> ValidGuid<T>(this IRuleBuilder<T, string?> ruleBuilder)
        {
            return ruleBuilder
                .Must(BeAValidGuid).WithMessage(ValidationErrors.InvalidGuid);
        }

        private static bool BeAValidGuid(string? guid)
        {
            return Guid.TryParse(guid, out _);
        }
    }
}
