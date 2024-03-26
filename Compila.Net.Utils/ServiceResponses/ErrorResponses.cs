using Compila.Net.Utils.Rest;

namespace Compila.Net.Utils.ServiceResponses
{
    public class ServiceBadRequestResponse : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceBadRequestResponse(string message) : base(false) => Message = message;
    }

    public class ServiceBadRequestResponseWithErrorCode : ServiceBadRequestResponse
    {
        public ErrorDetailsInResponse ErrorDetails { get; }
        public ServiceBadRequestResponseWithErrorCode(ErrorDetailsInResponse errorDetails) : base(errorDetails.Message ?? "No message.")
        {
            ErrorDetails = errorDetails;
        }
    }

    public class ServiceInternalServerError : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceInternalServerError(string message) : base(false) => Message = message;
    }

    public class ServiceInternalServerErrorWithErrorCode : ServiceInternalServerError
    {
        public ErrorDetailsInResponse ErrorDetails { get; }
        public ServiceInternalServerErrorWithErrorCode(ErrorDetailsInResponse errorDetails) : base(errorDetails.Message ?? "No message")
        {
            ErrorDetails = errorDetails;
        }
    }

    public class ServiceNotFoundResponse : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceNotFoundResponse(string message) : base(false) => Message = message;
    }

    public class ServiceUnauthorizedResponse : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceUnauthorizedResponse(string message) : base(false) => Message = message;
    }

    public class ServiceForbiddenResponse : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceForbiddenResponse(string message) : base(false) => Message = message;
    }

    public class ServiceConflictResponse : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceConflictResponse(string message) : base(false) => Message = message;
    }

    public class ServiceNotImplementedResponse : ServiceBaseResponse
    {
        public string Message { get; set; }
        public ServiceNotImplementedResponse(string message) : base(false) => Message = message;
    }

    public class ServiceErrorResponse : ServiceBaseResponse
    {
        public ErrorDetailsInResponse ErrorDetails { get; }

        public ServiceErrorResponse(ErrorDetailsInResponse errorDetailsInResponse) : base(false)
        {
            ErrorDetails = errorDetailsInResponse;
        }
    }
}
