using System.Collections.Generic;

namespace Compila.Net.Utils.Errors
{
    public abstract class ErrorCodes
    {
        public ErrorDictionary AuthenticationErrors { get; set; } = new ErrorDictionary();

        public ErrorCodes()
        {
            GenerateAuthenticationErrors();
        }

        void GenerateAuthenticationErrors()
        {
            AuthenticationErrors = new ErrorDictionary
            {
                { "E400001", "invalid_credentials" },
                { "E400002", "email_not_confirmed" },
                { "E400003", "duplicated_email" },
                { "E400004", "weak_password" }
            };
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
            {
                return this[errorCode];
            }
            else
            {
                return "unknown_error";
            }
        }
    }
}
