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

        public async Task<monetary_policy_data> GetForecasts(string policy_round_name, string series)
            => await _riskbankAPIClient.GetForecastsData(policy_round_name, series);


        public async Task<policy_rounds> GetPolicyRounds()
         => await _riskbankAPIClient.GetPolicyRoundsData();




        public async Task<Series> GetSeries()
            => await _riskbankAPIClient.GetSeriesData();

    }
}
