using Questoes.Infra.Integration;
using Questoes.Infra.Model;
using RestSharp;

namespace Questoes.Infra.Impl
{
    public class BaseApi : IBaseApi
    {
        public BaseApi()
        {

        }
        public RestClient CreateClient(string route)
        {
            return new RestClient(route);
        }

        public RestRequest CreateRequest(List<AddHeader> headers, Method method = Method.Get)
        {
            var request = new RestRequest
            {
                Method = method
            };
            foreach (var header in headers)
            {
                request.AddHeader(header.Header, header.HeaderValue);
            }
            return request;
        }

        public RestResponse ExecuteRequest(RestClient client, RestRequest request)
        {
            return client.Execute(request);
        }
    }
}
