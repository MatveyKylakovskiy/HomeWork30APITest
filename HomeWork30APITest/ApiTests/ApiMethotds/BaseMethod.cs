using HomeWork30APITest.ApiTests.ReqresAPI.Models.Response;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models;
using Newtonsoft.Json;
using RestSharp;

namespace HomeWork30APITest.ApiTests.ApiMethotds
{
    public abstract class BaseMethod
    {
        private static RestRequest _request;
        private static RestResponse _response;

        private protected BaseMethod CreateRequest(string recource, Method method)
        {
            _request = new RestRequest(recource, method);
            return this;
        }

        private protected RestResponse CreateResponse(RestClient client)
        {
            return _response = client.Execute(_request);

        }

        public T ReturnJsonContent<T>()
        {
            return JsonConvert.DeserializeObject<T>(_response.Content);
        }
        
        public int ReturnStatusCode()
        {
            return (int)_response.StatusCode;
        }
    }
}
