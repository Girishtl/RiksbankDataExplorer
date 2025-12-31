using Domain;

namespace Application.Interface
{
    public interface IRiskbankAPIClient
    {

        public Task<Series> GetSeriesData();

        public Task<policy_rounds> GetPolicyRoundsData();

        public Task<monetary_policy_data> GetForecastsData(string policy_round_name, string series);
    }
}
