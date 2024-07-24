﻿using HomeWork30APITest.ApiTests.ReqresAPIModels.Models;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace HomeWork30APITest.ApiTests.ApiMethotds
{
    public class MethodGET : BaseMethod
    {
        public void SendGetMethod(string resource, RestClient client)
        {
            CreateRequest(resource, Method.Get);
            CreateResponse(client);
        }

    }
}