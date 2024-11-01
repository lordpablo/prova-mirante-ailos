using Questoes.Infra.Model;
using RestSharp;

namespace Questoes.Infra.Integration
{
    public interface IBaseApi
    {
        RestClient CreateClient(string route);
        RestRequest CreateRequest(List<AddHeader> headers, Method method = Method.Get);
        RestResponse ExecuteRequest(RestClient client, RestRequest request);
    }
}
