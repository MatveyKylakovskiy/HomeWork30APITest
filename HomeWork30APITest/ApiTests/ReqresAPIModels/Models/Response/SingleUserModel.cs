

namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response
{

    public class SingleUserModel
    {

        public UserData data { get; set; }

        public class UserData
        {
            public int id { get; set; }
            public string email { get; set; }
            public string first_name { get; set; }
            public string last_name { get; set; }
        }
    }
}
