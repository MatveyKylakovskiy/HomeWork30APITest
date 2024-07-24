
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Request;

namespace HomeWork30APITest.ApiTests.ReqresAPIModels.Builders
{
    public class RegisterUserBuilder
    {
        private readonly RegisterUserModel _requets;

        public RegisterUserBuilder()
        {
            _requets = new RegisterUserModel();
        }

        public RegisterUserBuilder Email(string email)
        {

            _requets.Email = email;
            return this;
        }

        public RegisterUserBuilder Password(string password)
        {

            _requets.Password = password;
            return this;
        }

        public RegisterUserModel Build()
        {
            return _requets;
        }
    }
}
