using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Rest
{
    public class ErrorDetails
    {
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; } = new List<string>();

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
