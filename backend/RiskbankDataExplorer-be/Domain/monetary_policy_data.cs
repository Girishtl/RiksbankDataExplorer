using System.Text.Json.Serialization;

namespace Domain
{
    public class monetary_policy_data
    {
        [JsonPropertyName("data")]
        public List<SeriesData> Data { get; set; }
    }

    public class SeriesData
    {
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        [JsonPropertyName("vintages")]
        public Vintage Vintages { get; set; }
    }

    public class Vintage
    {
        [JsonPropertyName("metadata")]
        public VintageMetadata Metadata { get; set; }

        [JsonPropertyName("observations")]
        public List<Observation> Observations { get; set; }
    }

    public class VintageMetadata
    {
        [JsonPropertyName("forecast_cutoff_date")]
        public string ForecastCutoffDate { get; set; }

        [JsonPropertyName("policy_round")]
        public string? PolicyRound { get; set; }


        [JsonPropertyName("policy_round_code")]
        public string PolicyRoundCode { get; set; }


        [JsonPropertyName("policy_round_end_dtm")]
        public string PolicyRoundEndDtm { get; set; }
    }

    public class Observation
    {
        [JsonPropertyName("dt")]
        public string Dt { get; set; }

        [JsonPropertyName("value")]
        public long Value { get; set; }
    }


}
