using FluentValidation;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Validations.Extensions;

namespace PromptHub2.Server.Validations
{
    public class ConfirmEmailRequestValidator : AbstractValidator<ConfirmEmailRequest>
    {
        public ConfirmEmailRequestValidator() 
        {
            RuleFor(x => x.Email).ValidEmail();
            RuleFor(x => x.Token).ValidToken();
        }
    }
}
