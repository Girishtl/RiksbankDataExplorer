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
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });


        }
    }
}
