namespace Compila.Net.Utils.Errors.ErrorCodes.Authentication
{
    public static class AuthenticationErrorCodes
    {
        public const string InvalidCredentials = "E400001";
        public const string NotConfirmedEmail = "E400002";
        public const string DuplicatedEmail = "E400003";
        public const string PasswordTooShort = "E400004";
        public const string PasswordTooWeak = "E400005";
        public const string ErrorConfirmingEmail = "E400010";
        public const string InvalidEmailConfirmationToken = "E400011";
        public const string EmailConfirmationThresholdReached = "E400012";
    }
}
