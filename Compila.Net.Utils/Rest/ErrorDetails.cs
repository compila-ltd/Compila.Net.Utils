using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Rest
{
    public class ErrorDetails : ErrorDetailsBase
    {
        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; } = new List<string>();

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
