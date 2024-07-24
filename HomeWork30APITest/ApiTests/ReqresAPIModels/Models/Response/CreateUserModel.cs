
namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response
{
    public class CreateUserModel
    {
        public required string Name { get; set; }
        public required string Job {  get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
