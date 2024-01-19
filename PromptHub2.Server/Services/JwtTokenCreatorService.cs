using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PromptHub2.Server.Services
{
    public class JwtTokenCreatorService
    {
        private readonly JwtSettings _jwtSettings;
        private readonly UserManager<User> _userManager;
        public JwtTokenCreatorService(
            UserManager<User> userManager,
            IOptions<JwtSettings> jwtSettingsOptions) 
        { 
            _userManager = userManager;
            _jwtSettings = jwtSettingsOptions.Value;
        }

        public async Task<string> CreateTokenAsync(User user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id),
                new(ClaimTypes.Email, user.Email ?? ""),
                new(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach (var role in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, role));
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret));
            var singingCreds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: authClaims,
                notBefore: DateTime.UtcNow,
                issuer: _jwtSettings.ValidIssuer,
                audience: _jwtSettings.ValidAudience,
                expires: DateTime.UtcNow + _jwtSettings.Expire,
                signingCredentials: singingCreds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
