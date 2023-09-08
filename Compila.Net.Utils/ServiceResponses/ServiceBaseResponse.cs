﻿namespace Compila.Net.Utils.ServiceResponses
{
	public abstract class ServiceBaseResponse
	{
		public bool Success { get; set; }

		protected ServiceBaseResponse(bool success) => Success = success;
	}
}
