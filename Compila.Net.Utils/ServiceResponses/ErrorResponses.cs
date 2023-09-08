namespace Compila.Net.Utils.ServiceResponses
{
	public class ServiceBadRequestResponse : ServiceBaseResponse
	{
		public string Message { get; set; }
		public ServiceBadRequestResponse(string message) : base(false) => Message = message;
	}

	public class ServiceInternalServerError : ServiceBaseResponse
	{
		public string Message { get; set; }
		public ServiceInternalServerError(string message) : base(false) => Message = message;
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
		public string Message { get; set; }
		public int ErrorCode { get; set; }

		public ServiceErrorResponse(string message, int errorCode) : base(false)
		{
			Message = message;
			ErrorCode = errorCode;
		}
	}
}
