using System;

using RestSharp;

namespace Compila.Net.Utils.Http
{
	public class BaseRequest
	{
		public RestRequest RestRequest { get; set; }

		public BaseRequest(RestRequest restRequest)
		{
			RestRequest = restRequest;
		}
	}
}
