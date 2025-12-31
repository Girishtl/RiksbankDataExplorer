using System.Text.Json.Serialization;

namespace Domain
{
    public class Series
    {
        public List<DataItem> Data { get; set; }
    }

    public class DataItem
    {
        public string Series_Id { get; set; }
        public Metadata Metadata { get; set; }
    }

    public class Metadata
    {
        public decimal Decimals { get; set; }
        public string Start_Date { get; set; }
        public string Description { get; set; }
        public string Source_Agency { get; set; }
        public string Unit { get; set; }


        [JsonPropertyName("note")]
        public string? Note { get; set; }
    }

}
