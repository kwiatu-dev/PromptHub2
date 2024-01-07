using FluentValidation;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Validations.Extensions;

namespace PromptHub2.Server.Validations
{
    public class ForgotPasswordRequestValidator : AbstractValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordRequestValidator() 
        {
            RuleFor(x => x.Email).ValidEmail();
        }
    }
}
