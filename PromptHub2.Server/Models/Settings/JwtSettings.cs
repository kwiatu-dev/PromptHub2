namespace PromptHub2.Server.Models.Settings
{
    public class JwtSettings
    {
        public string Secret { get; set; } = string.Empty;
        public string? ValidIssuer { get; set; }
        public string? ValidAudience { get; set; }
        public int ExpirationTimeInMinutes { get; set; }
        public TimeSpan Expire => TimeSpan.FromMinutes(ExpirationTimeInMinutes);
    }
}
