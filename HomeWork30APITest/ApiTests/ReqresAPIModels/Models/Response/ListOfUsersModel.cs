using HomeWork30APITest.ApiTests.ReqresAPIModels.Models;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response;
using Newtonsoft.Json;

namespace HomeWork30APITest.ApiTests.ReqresAPI.Models.Response
{
    public class ListOfUsersModel
    {
        [JsonProperty("data")]
        public List<User> Users { get; set; }
    }

    public class User
    {

        [JsonProperty("id")]
        public required int id { get; set; }

        [JsonProperty("email")]
        public required string Email { get; set; }

        [JsonProperty("first_name")]
        public required string First_Name { get; set; }

        [JsonProperty("last_name")]
        public required string Last_Name { get; set; }
    }
}


