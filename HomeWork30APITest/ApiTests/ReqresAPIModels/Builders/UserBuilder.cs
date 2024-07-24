
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Request;

namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Builders
{
    public class UserBuilder
    {
        private readonly UserModel _requets;

        public UserBuilder()
        {
            _requets = new UserModel();
        }

        public UserBuilder Name(string name)
        {

            _requets.Name = name;
            return this;
        }

        public UserBuilder Job(string job)
        {

            _requets.Job = job;
            return this;
        }

        public UserModel Build()
        {
            return _requets;
        }
    }
}
