using HomeWork30APITest.ApiTests.ApiMethotds;
using RestSharp;

namespace HomeWork30APITest.ApiTests.Tests
{
    public class BaseAPITest
    {
        private const string BaseUrl = "https://reqres.in/api/";
        public RestClient client;
        public BaseMethod Response;

        [SetUp]
        public void Setup()
        {
            client = new RestClient(BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            client.Dispose();
        }
    }
}
