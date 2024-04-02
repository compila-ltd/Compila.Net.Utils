﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.RestApi.ActionFilters
{
	public class ActionFilterMessage
	{
		[JsonPropertyName("message")]
		public string? Message { get; set; }
		[JsonPropertyName("errors")]
		public List<string>? Errors { get; set; }
	}
}
