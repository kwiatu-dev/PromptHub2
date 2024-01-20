﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Ocsp;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models.Entites;
using PromptHub2.Server.Models.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace PromptHub2.Server.Services
{
    public class JwtUtilsService : IJwtUtilsService
    {
        private readonly JwtUtilsSettings _jwtUtilsSettings;
        private readonly UserManager<User> _userManager;
        public JwtUtilsService(
            UserManager<User> userManager,
            IOptions<JwtUtilsSettings> jwtSettingsOptions) 
        { 
            _userManager = userManager;
            _jwtUtilsSettings = jwtSettingsOptions.Value;
        }

        public async Task<string> CreateAccessTokenAsync(User user)
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

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtUtilsSettings.Secret));
            var singingCreds = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: authClaims,
                notBefore: DateTime.UtcNow,
                issuer: _jwtUtilsSettings.ValidIssuer,
                audience: _jwtUtilsSettings.ValidAudience,
                expires: DateTime.UtcNow + _jwtUtilsSettings.AccessTokenExpire,
                signingCredentials: singingCreds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public string? ValidateAccessToken(string token)
        {
            if (!string.IsNullOrEmpty(token)) 
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtUtilsSettings.Secret));

                try
                {
                    tokenHandler.ValidateToken(token, new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = _jwtUtilsSettings.ValidIssuer,
                        ValidAudience = _jwtUtilsSettings.ValidAudience,
                        IssuerSigningKey = securityKey,
                        ClockSkew = TimeSpan.Zero,
                    }, out SecurityToken validatedToken);

                    var jwtToken = (JwtSecurityToken)validatedToken;
                    var userId = jwtToken.Claims.FirstOrDefault(c => c.ValueType == ClaimTypes.NameIdentifier)?.Value;

                    return userId;
                }
                catch { }
            }

            return null;
        }

        public RefreshToken CreateRefreshToken(string ipAddress)
        {
            RefreshToken refreshToken = new() 
            { 
                Id = Guid.NewGuid().ToString(),
                Token = GetUniqueToken(),
                CreatedAt = DateTime.UtcNow,
                CreatedByIp = ipAddress,
                Expires = DateTime.UtcNow + _jwtUtilsSettings.RefreshTokenExpire,
            };

            return refreshToken;

            string GetUniqueToken()
            {
                var token = Guid.NewGuid().ToString();
                var isUnique = _userManager.Users.Any(u => u.RefreshTokens.Any(t => t.Token == token));

                if(!isUnique)
                {
                    return GetUniqueToken();
                }

                return token;
            }
        }

        public void RemoveObsoleteRefreshTokensAsync(User user)
        {
            user.RefreshTokens.RemoveAll(t => 
                !t.IsActive && 
                t.CreatedAt.AddDays(_jwtUtilsSettings.RefreshTokenTTL) <= DateTime.UtcNow);
        }

        public void RevokeRefreshToken(RefreshToken refreshToken, string? replaceByToken = null, string? reasonRevoked = null, string? ipAddress = null)
        {
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.ReplacedByToken = replaceByToken;
            refreshToken.ReasonRevoked = reasonRevoked;
            refreshToken.RevokedByIp = ipAddress;
        }

        public void RevokeDescendantRefreshTokens(User user, RefreshToken refreshToken, string? reasonRevoked = null, string? ipAddress = null)
        {
            if (!string.IsNullOrEmpty(refreshToken.ReplacedByToken))
            {
                var childRefreshToken = user.RefreshTokens.SingleOrDefault(t => t.Token == refreshToken.ReplacedByToken);

                if (childRefreshToken != null)
                {
                    if (childRefreshToken.IsActive)
                    {
                        RevokeRefreshToken(childRefreshToken, reasonRevoked, ipAddress);
                    }

                    RevokeDescendantRefreshTokens(user, childRefreshToken, reasonRevoked, ipAddress);
                }
            }
        }

        public RefreshToken RotateRefreshToken(RefreshToken refreshToken, string ipAddress)
        {
            var newRefreshToken = CreateRefreshToken(ipAddress);
            RevokeRefreshToken(refreshToken, newRefreshToken.Token, "Replaced by new token", ipAddress);

            return newRefreshToken;
        }

        public async Task<bool> RevokeTokenAsync(string token, string reasonRevoked, string ipAddress)
        {
            var user = _userManager.Users.SingleOrDefault(u => u.RefreshTokens.Any(t => t.Token == token));

            if (user != null) 
            {
                var refreshToken = user.RefreshTokens.Single(t => t.Token == token);

                if (refreshToken.IsActive)
                {
                    RevokeRefreshToken(refreshToken, reasonRevoked, ipAddress);
                    await _userManager.UpdateAsync(user);
                }

                return true;
            }

            return false;
        }
    }
}
