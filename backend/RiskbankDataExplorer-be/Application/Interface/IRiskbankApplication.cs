using Domain;

namespace Application.Interface
{
    public interface IRiskbankApplication
    {
        public Task<monetary_policy_data> GetForecasts(string policy_round_name, string series);

        public Task<policy_rounds> GetPolicyRounds();


        public Task<Series> GetSeries();
    }
}
