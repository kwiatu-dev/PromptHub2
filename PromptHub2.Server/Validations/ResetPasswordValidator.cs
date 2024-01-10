using FluentValidation;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Validations.Extensions;

namespace PromptHub2.Server.Validations
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordRequest>
    {
        public ResetPasswordValidator() 
        {
            RuleFor(x => x.Email).ValidEmail();
            RuleFor(x => x.Password).ValidPassword();
            RuleFor(x => x.ConfirmPassword).ValidConfirmPassword(x => x.Password);
            RuleFor(x => x.Token).ValidToken();

        }
    }
}
