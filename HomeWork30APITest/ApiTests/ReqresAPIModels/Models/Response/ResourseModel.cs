
using Newtonsoft.Json;

namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response
{
    public class ResourseModel
    {
        [JsonProperty("data")]
        public List<ResourseItem> Items { get; set; }
    }

    public class ResourseItem
    {

        [JsonProperty("id")]
        public required int id { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("year")]
        public required int Year { get; set; }

        [JsonProperty("color")]
        public required string Color { get; set; }

        [JsonProperty("pantone_value")]
        public required string PantoneValue { get; set; }
    }
}

