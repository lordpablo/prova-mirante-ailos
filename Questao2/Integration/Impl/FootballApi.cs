using Newtonsoft.Json;
using Questao2.Integration.Response;
using Questoes.Infra.Impl;
using Questoes.Infra.Model;
using RestSharp;

namespace Questao2.Integration.Impl
{
    public class FootballApi : IFootballApi
    {
        public FootballApi()
        {

        }

        public BaseResponse<FootballMatches> ReturnMatches(int year, string team1, int page, string team2 = "")
        {
            var baseReturn = new BaseResponse<FootballMatches>();
            var baseApi = new BaseApi();
            var client = baseApi.CreateClient("https://jsonmock.hackerrank.com/api/football_matches");
            var headers = new List<AddHeader> {
                new AddHeader
                {
                    Header = "Content-Type",
                    HeaderValue = "application/json"
                }
            };

            var request = baseApi.CreateRequest(headers);
            request.AddParameter("year", year);
            request.AddParameter("team1", team1);
            request.AddParameter("page", page);

            if (!string.IsNullOrEmpty(team2))
                request.AddParameter("team2", team2);

            try
            {
                var response = baseApi.ExecuteRequest(client, request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return JsonConvert.DeserializeObject<BaseResponse<FootballMatches>>(response.Content);
                }
                return baseReturn;
            }
            catch (Exception)
            {
                return baseReturn;
            }
        }
    }
}
