namespace Compila.Net.Utils.Errors
{
    public abstract class ErrorCodesBase
    {
        public ErrorDictionary AuthenticationErrors { get; set; } = new ErrorDictionary();
    }

    internal static class ErrorCodesExtensions
    {
        public static ErrorCodesBase GenerateBasicAuthenticationErrors(this ErrorCodesBase @this)
        {
            @this.AuthenticationErrors = new ErrorDictionary
            {
                { "E400001", "invalid_credentials" },
                { "E400002", "email_not_confirmed" },
                { "E400003", "duplicated_email" },
                { "E400004", "weak_password" }
            };

            return @this;
        }
    }

    public class ErrorDictionary : Dictionary<string, string>
    {
        public string GetError(ErrorDetailsWithCode errorDetails)
        {
            return GetError(errorDetails.ErrorCode ?? "");
        }

        public string GetError(string errorCode)
        {
            if (this.ContainsKey(errorCode))
                return this[errorCode];

            return "unknown_error";
        }
    }
}
