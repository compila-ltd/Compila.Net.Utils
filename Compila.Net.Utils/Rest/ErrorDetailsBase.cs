using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Rest
{
    public abstract class ErrorDetailsBase
    {
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
        [JsonPropertyName("message")]
        public string? Message { get; set; }
    }
}
