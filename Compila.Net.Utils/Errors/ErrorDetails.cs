using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Errors
{
	public abstract class ErrorDetailsBase
	{
		[JsonPropertyName("statusCode")]
		public int StatusCode { get; set; }
		[JsonPropertyName("message")]
		public string Message { get; set; }

		public ErrorDetailsBase(string message, int statusCode)
		{
			Message = message;
			StatusCode = statusCode;
		}

		public override string ToString() => JsonSerializer.Serialize(this);
	}

	public class ErrorDetails : ErrorDetailsBase
	{
		public ErrorDetails(string message, int statusCode) : base(message, statusCode) { }
	}

	public class ErrorDetailsList : ErrorDetailsBase
	{
		[JsonPropertyName("errors")]
		public List<string> Errors { get; set; } = new List<string>();

		public ErrorDetailsList(string message, int statusCode) : base(message, statusCode) { }
	}

	public class ErrorDetailsWithCode : ErrorDetailsBase
	{
		[JsonPropertyName("errorCode")]
		public string? ErrorCode { get; set; }

		public ErrorDetailsWithCode(string message, int statusCode, string errorCode) : base(message, statusCode)
		{
			ErrorCode = errorCode;
		}
	}
}
