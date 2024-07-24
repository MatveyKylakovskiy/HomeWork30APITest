
using Newtonsoft.Json;

namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response
{

    public class SingleUserModel
    {
        [JsonProperty("data.id")]
        public required int id { get; set; }

        [JsonProperty("data.email")]
        public required string Email { get; set; }

        [JsonProperty("data.first_name")]
        public required string First_Name { get; set; }

        [JsonProperty("data.last_name")]
        public required string Last_Name { get; set; }

    }
}
