using Questao2.Integration.Response;

namespace Questao2.Integration
{
    public interface IFootballApi
    {
        BaseResponse<FootballMatches> ReturnMatches(int year, string team1, int page, string team2 = "");
    }
}
