﻿namespace PromptHub2.Server.Models
{
    public class ConfirmEmailRequest
    {
        public string Email { get; set; } = string.Empty;
        public string Token {  get; set; } = string.Empty;
    }
}
