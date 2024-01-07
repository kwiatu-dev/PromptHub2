﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PromptHub2.Server.Constants;
using PromptHub2.Server.Interfaces;
using PromptHub2.Server.Models;
using PromptHub2.Server.Models.Requests;
using PromptHub2.Server.Models.Responses;
using System;
using System.Security.Policy;

namespace PromptHub2.Server.Controllers
{
    [Route("Account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService) 
        {
            _accountService = accountService;
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest request)
        {
            await _accountService.ForgotPasswordAsync(request);

            return Ok(new SuccedResponse
            {
                Message = Messages.ResetPasswordLinkSend
            });
        }

        [HttpPost]
        [Route("ResetPassword")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest request)
        {
            bool result = await _accountService.ResetPasswordAsync(request);

            if(result)
            {
                return Ok(new SuccedResponse
                {
                    Message = Messages.PasswordReseted

                });
            }

            return BadRequest(new ErrorResponse
            {
                Message = Errors.LinkExpired
            });
        }
    }
}
