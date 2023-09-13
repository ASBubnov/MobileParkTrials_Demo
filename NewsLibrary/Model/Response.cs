using System.Text.Json.Serialization;


namespace NewsLibrary.Model
{
    public class Response
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("totalResults")]
        public int TotalResults { get; set; }
        [JsonPropertyName("articles")]
        public List<News> Articles { get; set; } 
    }
}
