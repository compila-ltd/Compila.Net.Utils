namespace Compila.Net.Utils.Errors.ErrorCodes.Authentication
{
    internal static class ErrorCodesExtensions
    {
        public static ErrorCodesBase GenerateBasicAuthenticationErrors(this ErrorCodesBase @this)
        {
            @this.AuthenticationErrors = new ErrorDictionary
            {
                { "E400001", "invalid_credentials" },
                { "E400002", "email_not_confirmed" },
                { "E400003", "duplicated_email" },
                { "E400004", "password_too_short" },
                { "E400005", "weak_password" },
                { "E400010", "error_confirming_email" },
                { "E400011", "invalid_email_confirmation_token" },
                { "E400012", "email_confirmation_threshold_reached" }
            };

            return @this;
        }
    }
}
