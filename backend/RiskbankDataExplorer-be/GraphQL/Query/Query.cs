
using Application.Interface;
using Domain;

namespace GraphQL.Query
{
    public class Query
    {


        [GraphQLName("monetary_policy_series_data")]
        [UseFiltering]

        public async Task<Series> GetAllSeries(IRiskbankApplication riskbankApplication)
        { return await riskbankApplication.GetSeries(); }




        [GraphQLName("monetary_policy_policy_rounds_data")]
        [UseFiltering]

        public async Task<policy_rounds> GetAllpolicy(IRiskbankApplication riskbankApplication)
        { return await riskbankApplication.GetPolicyRounds(); }




        [GraphQLName("monetary_policy_policy_forecasts")]
        [UseFiltering]

        public async Task<monetary_policy_data> GetAlForecast(IRiskbankApplication riskbankApplication, string policy_round_name, string series)
        { return await riskbankApplication.GetForecasts(policy_round_name, series); }
    }
}
