namespace HouseRent.Globals
{
    public static class ErrorMessages
    {
        public const string RequiredErrorMessage = "The {0} field is required.";
        public static class User
        {
            public const string InvalidUserNameOrPassword = "Invalid username or password.";
            public const string UserAlreadyExists = "User with the same username or email already exists.";

            public const string MinLengthError = "The {0} must be at least {2} characters long.";
            public const string MaxLengthError = "The {0} must be maximum {2} characters long.";

            public const string PasswordsDoNotMatch = "The password and confirmation password do not match.";
        }
    }
}
