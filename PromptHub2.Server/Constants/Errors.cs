namespace PromptHub2.Server.Constants
{
    public static class Errors
    {
        public const string ResetPasswordError = "There was a problem when trying to reset the password.";
        public const string LinkExpired = "The link has expired.";
        public const string LoginAttemptsExceeded = "The limit of login attempts has been exceeded.";
        public const string NotVerifiedEmail = "Email address not verified.";
        public const string InvalidEmailOrPassword = "Invalid email address or password.";
        public const string CreateUserError = "There was a problem when trying to create a user.";
        public const string CouldNotVerifiedEmail = "The email address could not be verified.";
        public const string UserNotExistOrUnauthorized = "The user does not exist or does not have access to the resource.";
        public const string ErrorOccurred = "At least one error has occurred";
        public const string UserDoesNotHaveRights = "The user does not have the following rights:";
        public const string AccessDenied = "Access denied.";
        public const string ServerConfigurationError = "An unexpected error occurred on the server configuration side";
        public const string EntityNotFound = "{0} was not found.";
        public const string RefreshTokenFail = "Refresh token fail.";
    }
}
