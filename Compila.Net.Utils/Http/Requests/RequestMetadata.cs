using System;
using System.Text.Json.Serialization;

namespace Compila.Net.Utils.Http.Requests
{
    [Obsolete]
    public class RequestMetadata
    {
        [JsonPropertyName("currentPage")]
        public int CurrentPage { get; set; }
        [JsonPropertyName("totalPages")]
        public int TotalPages { get; set; }
        [JsonPropertyName("pageSize")]
        public int PageSize { get; set; }
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }
        [JsonPropertyName("hasPrevious")]
        public bool HasPrevious => CurrentPage > 1;
        [JsonPropertyName("hasNext")]
        public bool HasNext => CurrentPage < TotalPages;
    }
}
