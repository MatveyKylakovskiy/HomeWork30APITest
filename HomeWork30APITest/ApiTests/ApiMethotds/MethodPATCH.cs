﻿
using RestSharp;

namespace HomeWork30APITest.ApiTests.ApiMethotds
{
    public class MethodPATCH : BaseMethod
    {
        public void SendPatchMethod<T>(string resource, RestClient client, T jsonReq) where T : class
        {
            CreateRequest(resource, Method.Patch);
            _request.AddJsonBody(jsonReq);
            CreateResponse(client);
        }
    }
}