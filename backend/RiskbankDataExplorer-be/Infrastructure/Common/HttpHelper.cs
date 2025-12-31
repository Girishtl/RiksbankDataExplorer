using System.Text.Json;

namespace Infrastructure.Common
{
    public static class HttpHelper
    {
        private static readonly HttpClient _client;

        static HttpHelper()
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");

        }

        public static async Task<T> GetDataAync<T>(string url)
        {


            //var urls = "https://api.riksbank.se/monetary_policy_data/v1/forecasts/series_ids";
            // Send GET request
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            // Read raw JSON
            var json = await response.Content.ReadAsStringAsync();
            Console.WriteLine("RAW RESPONSE:"); Console.WriteLine(json);
            // Deserialize
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


        }
    }
}
