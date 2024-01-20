namespace PromptHub2.Server.Models.Settings
{
    public class JwtUtilsSettings
    {
        public string Secret { get; set; } = string.Empty;
        public string? ValidIssuer { get; set; }
        public string? ValidAudience { get; set; }
        public int AccessTokenExpirationTimeInMinutes { get; set; }
        public int RefreshTokenExpirationTimeInMinutes { get; set; }
        public int RefreshTokenTTL { get; set; }
        public TimeSpan AccessTokenExpire => TimeSpan.FromMinutes(AccessTokenExpirationTimeInMinutes);
        public TimeSpan RefreshTokenExpire => TimeSpan.FromMinutes(RefreshTokenExpirationTimeInMinutes);
    }
}
