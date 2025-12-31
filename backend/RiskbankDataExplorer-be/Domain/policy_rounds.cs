using System.Text.Json.Serialization;

namespace Domain
{
    public class policy_rounds
    {
        [JsonPropertyName("data")]
        public List<string> Data { get; set; }
    }
}
