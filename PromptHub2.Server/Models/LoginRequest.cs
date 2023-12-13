﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PromptHub2.Server.Models
{
    public class LoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
