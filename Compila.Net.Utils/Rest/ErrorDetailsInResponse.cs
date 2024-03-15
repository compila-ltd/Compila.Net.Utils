using System.Text.Json;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Rest
{
    public class ErrorDetailsInResponse
    {
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
        [JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
