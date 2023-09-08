namespace Compila.Net.Utils.ServiceResponses
{
	public class ServiceOkResponse<TResult> : ServiceBaseResponse
	{
		public TResult Result { get; set; }

		public ServiceOkResponse(TResult result) : base(true) => Result = result;

	}

	public class ServiceOkResponse : ServiceBaseResponse
	{
		public ServiceOkResponse() : base(true)
		{
		}
	}

	public class ServiceCreatedResponse : ServiceBaseResponse
	{
		public ServiceCreatedResponse() : base(true)
		{
		}
	}
}
