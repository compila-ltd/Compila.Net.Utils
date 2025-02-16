namespace Compila.Net.Utils.Errors.ErrorCodes
{
    public abstract class ErrorCodesBase
    {
        public ErrorDictionary AuthenticationErrors { get; set; } = [];
    }

    public class ErrorDictionary : Dictionary<string, string>
    {
        public string GetError(ErrorDetailsWithCode errorDetails)
        {
            return GetError(errorDetails.ErrorCode ?? "");
        }

        public string GetError(string errorCode)
        {
            if (ContainsKey(errorCode))
                return this[errorCode];

            return "unknown_error";
        }
    }
}
