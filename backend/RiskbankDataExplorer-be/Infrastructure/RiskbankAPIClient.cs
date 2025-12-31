using Application.Interface;
using Domain;
using Infrastructure.Common;

namespace Infrastructure
{
    public class RiskbankAPIClient : IRiskbankAPIClient
    {

        private readonly string _baseUrl = "https://api.riksbank.se/";

        private readonly string _seriesEndpoint = "monetary_policy_data/v1/forecasts/series_ids";

        private readonly string _policy_roundsEndpoint = "monetary_policy_data/v1/forecasts/policy_rounds";

        private readonly string _forecastsEndpoint = "monetary_policy_data/v1/forecasts";


        public RiskbankAPIClient() { }


        public async Task<Series> GetSeriesData()
           => await HttpHelper.GetDataAync<Series>(_baseUrl + _seriesEndpoint);

        public async Task<policy_rounds> GetPolicyRoundsData()
           => await HttpHelper.GetDataAync<policy_rounds>(_baseUrl + _policy_roundsEndpoint);


        public async Task<monetary_policy_data> GetForecastsData(string policy_round_name, string series)
            => await HttpHelper.GetDataAync<monetary_policy_data>($"{_baseUrl}{_forecastsEndpoint}?policy_round_name={policy_round_name}&series={series}");

    }

}
