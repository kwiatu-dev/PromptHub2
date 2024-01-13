namespace PromptHub2.Server.Constants
{
    public static class ValidationErrors
    {
        //Authenticate && Account
        public const string EmailEmpty = "The email field must not be empty.";
        public const string IncorrectEmailFormat = "Incorrect email address format.";
        public const string TokenNotProvided = "The token must be provided.";
        public const string PasswordEmpty = "The password field must not be empty.";
        public const string PasswordLength = "The password must be at least eight characters long.";
        public const string PasswordCapitalLetter = "The password must contain at least one capital letter.";
        public const string PasswordLowercaseLetter = "The password must contain at least one lowercase letter.";
        public const string PasswordDigit = "The password must contain at least one digit.";
        public const string PasswordSpecialCharacter = "The password must contain at least one special character.";
        public const string ConfirmPasswordEmpty = "Password confirmation is required.";
        public const string ConfirmPasswordNotMatch = "The password confirmation does not match the password.";

        //Projects
        public const string EmptyField = "The {0} field must not be empty";
        public const string MinimumLengthText = "The minimum number of characters is {0}";
        public const string MaximumLengthText = "The maximum number of characters is {0}";
    }
}
