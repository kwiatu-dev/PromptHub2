﻿using System.ComponentModel.DataAnnotations;

namespace PromptHub2.Server.Models
{
    public class RegisterRequest
    {
        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}