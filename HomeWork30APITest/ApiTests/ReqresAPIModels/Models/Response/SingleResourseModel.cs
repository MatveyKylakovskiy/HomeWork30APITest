

namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response
{
    public class SingleResourseModel
    {
        public ResourseData data { get; set; }

        public class ResourseData
        {
            public int id { get; set; }
            public string name { get; set; }
            public int year { get; set; }
            public string color { get; set; }
            public string pantone_value { get; set; }
        }
    }
}
