using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PromptHub2.Server.Helpers
{
    public static class ExtractErrors
    {
        public static Dictionary<string, string[]> FromModelState(ModelStateDictionary ModelState)
        {
            return ModelState
                .Where(ms => ms.Value?.Errors != null && ms.Value.Errors.Any())
                .ToDictionary(
                    ms => ms.Key,
                    ms => ms.Value?.Errors.Select(e => e.ErrorMessage).ToArray() ?? Array.Empty<string>()
                );
        }
    }
}
