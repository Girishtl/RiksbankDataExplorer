using Application.Interface;
using Domain;

namespace Application.Service
{
    public class RiskbankApplication : IRiskbankApplication
    {
        private readonly IRiskbankAPIClient _riskbankAPIClient;


        public RiskbankApplication(IRiskbankAPIClient riskbankAPIClient)
        {
            _riskbankAPIClient = riskbankAPIClient;
        }

        public Task<monetary_policy_data> GetForecasts(string policy_round_name, string series)
        {
            var x = _riskbankAPIClient.GetForecastsData(policy_round_name, series);

            return x;
        }

        public Task<policy_rounds> GetPolicyRounds()
        {
            var x = _riskbankAPIClient.GetPolicyRoundsData();

            return x;
        }

        public async Task<Series> GetSeries()
        {
            var x = await _riskbankAPIClient.GetSeriesData();

            return x;
        }
    }
}
