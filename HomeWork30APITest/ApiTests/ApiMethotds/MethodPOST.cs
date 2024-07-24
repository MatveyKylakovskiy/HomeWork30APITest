
using RestSharp;

namespace HomeWork30APITest.ApiTests.ApiMethotds
{
    public class MethodPOST : BaseMethod
    {
        public void SendPostMethod<T>(string resource, RestClient client, T jsonReq) where T : class
        {
            CreateRequest(resource, Method.Post);
            _request.AddJsonBody(jsonReq);
            CreateResponse(client);
        }

    }
}
