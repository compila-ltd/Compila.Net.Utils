using System.Text.Json;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Rest
{
    public class ErrorDetailsInResponse : ErrorDetailsBase
    {
        [JsonPropertyName("errorCode")]
        public string? ErrorCode { get; set; }

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
