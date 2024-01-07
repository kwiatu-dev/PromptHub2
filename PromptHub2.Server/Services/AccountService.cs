﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Controllers;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Models.Data;
using PromptHub2.Server.Models.Requests;
using System;
using System.Security.Policy;
using System.Web;

namespace PromptHub2.Server.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IMailService _mailService;
        private readonly IConfiguration _configuration;

        public AccountService(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IMailService mailService,
            IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mailService = mailService;
            _configuration = configuration;
        }

        public async Task<bool> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
                var baseUrl = _configuration["Endpoints:Client"];
                var resetLink = $"{baseUrl}/Account/{nameof(AccountController.ResetPassword)}?token={HttpUtility.UrlEncode(resetToken)}&email={HttpUtility.UrlEncode(user.Email)}";

                var mailData = new MailData
                {
                    EmailToId = user.Email,
                    EmailSubject = "Reset password",
                    EmailBody = resetLink,
                };

                return await _mailService.SendMailAsync(mailData); ;
            }

            return false;
        }

        public async Task<bool> ResetPasswordAsync(ResetPasswordRequest request)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user != null)
            {
                var result = await _userManager.ResetPasswordAsync(user, request.Token, request.Password);

                if (!result.Errors.Any())
                {
                    return true;
                }
            }

            return false;
        }
    }
}
