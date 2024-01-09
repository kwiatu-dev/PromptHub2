using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PromptHub2.Server.Constants;

namespace PromptHub2.Server.Helpers
{
    public static class ExtractErrors
    {
        public static Dictionary<string, string[]> FromModelState(ModelStateDictionary ModelState)
        {
            return ModelState
                .Where(ms => ms.Value?.Errors != null && ms.Value.Errors.Any())
                .ToDictionary(
                    ms => ms.Key.ToLower(),
                    ms => ms.Value?.Errors.Select(e => e.ErrorMessage).ToArray() ?? Array.Empty<string>()
                );
        }

        public static Dictionary<string, string[]> ExtractFailedRequirements(AuthorizationFailure failure)
        {
            if(failure != null)
            {
                var errors = failure.FailedRequirements
                    .Select(failedRequirement => DescribeRequirement(failedRequirement))
                    .ToArray();

                return new Dictionary<string, string[]> { { Form.OtherErrorsFieldName, errors } };
            }

            return new Dictionary<string, string[]>();
        }

        private static string DescribeRequirement(IAuthorizationRequirement requirement)
        {

            if(requirement is RolesAuthorizationRequirement rolesRequirement)
            {
                return $"{Errors.UserDoesNotHaveRights} {string.Join(", ", rolesRequirement.AllowedRoles)}";
            }

            return requirement.GetType().Name;
        }
    }
}
