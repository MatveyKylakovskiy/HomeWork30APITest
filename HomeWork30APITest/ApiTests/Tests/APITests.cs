using HomeWork30APITest.ApiTests.ApiMethotds;
using HomeWork30APITest.ApiTests.ReqresAPI.Models.Response;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace HomeWork30APITest.ApiTests.Tests
{
    public class Tests : BaseAPITest
    {
        [Test]
        [Description("Get List of Users")]
        public void GetMethodTest1()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users?page=2", client);
            
            ListOfUsersModel listOfUsers = getMethodObj.ReturnJsonContent< ListOfUsersModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(listOfUsers.Users[0].id, Is.EqualTo(7));
            Assert.That(listOfUsers.Users[1].First_Name, Is.EqualTo("Lindsay"));
            Assert.That(listOfUsers.Users[2].Email, Is.EqualTo("tobias.funke@reqres.in"));
            Assert.That(listOfUsers.Users[3].Last_Name, Is.EqualTo("Fields"));
        }

        [Test]
        [Description("Get single User")]
        public void GetMethodTest2()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users/2", client);

            SingleUserModel singleUser = getMethodObj.ReturnJsonContent<SingleUserModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleUser.id, Is.EqualTo(2));
            Assert.That(singleUser.First_Name, Is.EqualTo("Janet"));
            Assert.That(singleUser.Email, Is.EqualTo("janet.weaver@reqres.in"));
            Assert.That(singleUser.Last_Name, Is.EqualTo("Weaver"));
        }
    }
}