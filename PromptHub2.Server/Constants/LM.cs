namespace PromptHub2.Server.Constants
{
    public static class LM
    {
        public static readonly string[] Models = { "gpt-3.5", "gpt-4" };
        public static readonly string[] Roles = { "assistant", "system", "user" };
        public const string DefaultModel = "gpt-3.5";
    }
}
