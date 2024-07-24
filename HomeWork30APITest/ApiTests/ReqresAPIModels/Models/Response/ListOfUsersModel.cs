using HomeWork30APITest.ApiTests.ReqresAPIModels.Models;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response;
using Newtonsoft.Json;

namespace HomeWork30APITest.ApiTests.ReqresAPI.Models.Response
{
    public class ListOfUsersModel : BaseModel
    {
        [JsonProperty("data")]
        public List<SingleUserModel> Users { get; set; }
    }
}


