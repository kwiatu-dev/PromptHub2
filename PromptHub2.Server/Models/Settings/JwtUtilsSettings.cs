namespace PromptHub2.Server.Models.Settings
{
    public class JwtUtilsSettings
    {
        public string Secret { get; set; } = string.Empty;
        public string? ValidIssuer { get; set; }
        public bool ValidateIssuer { get; set; }
        public string? ValidAudience { get; set; }
        public bool ValidateAudience { get; set; }
        public int AccessTokenExpirationTimeInMinutes { get; set; }
        public int RefreshTokenExpirationTimeInMinutes { get; set; }
        public bool ValidateLifetime { get; set; }
        public bool ValidateIssuerSigningKey { get; set; }
        public int RefreshTokenTTL { get; set; }
        public TimeSpan AccessTokenExpire => TimeSpan.FromMinutes(AccessTokenExpirationTimeInMinutes);
        public TimeSpan RefreshTokenExpire => TimeSpan.FromMinutes(RefreshTokenExpirationTimeInMinutes);
    }
}
