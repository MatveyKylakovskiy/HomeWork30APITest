using HomeWork30APITest.ApiTests.ApiMethotds;
using HomeWork30APITest.ApiTests.ReqresAPI.Models.Response;
using HomeWork30APITest.ApiTests.ReqresAPIModels.Models.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.ComponentModel;

namespace HomeWork30APITest.ApiTests.Tests
{
    public class Tests : BaseAPITest
    {
        [Test]
        [DisplayName("Get List of Users")]
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
        [DisplayName("Get single User")]
        public void GetMethodTest2()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users/2", client);

            SingleUserModel singleUser = getMethodObj.ReturnJsonContent<SingleUserModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleUser.data.id, Is.EqualTo(2));
            Assert.That(singleUser.data.first_name, Is.EqualTo("Janet"));
            Assert.That(singleUser.data.email, Is.EqualTo("janet.weaver@reqres.in"));
            Assert.That(singleUser.data.last_name, Is.EqualTo("Weaver"));
        }

        [Test]
        [DisplayName("Single User not found")]
        public void GetMethodTest3()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("users/23", client);

            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(404), "status code is not 404");
        }

        [Test]
        [DisplayName("Get LIST <RESOURCE>")]
        public void GetMethodTest4()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("unknown", client);

            ListOfResourseModel singleResourse = getMethodObj.ReturnJsonContent<ListOfResourseModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleResourse.Items[0].id, Is.EqualTo(1));
            Assert.That(singleResourse.Items[1].Name, Is.EqualTo("fuchsia rose"));
            Assert.That(singleResourse.Items[2].Color, Is.EqualTo("#BF1932"));
            Assert.That(singleResourse.Items[3].Year, Is.EqualTo(2003));
            Assert.That(singleResourse.Items[4].PantoneValue, Is.EqualTo("17-1456"));
        }

        [Test]
        [DisplayName("Get single <RESOURCE>")]
        public void GetMethodTest5()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("unknown/2", client);

            SingleResourseModel singleResourse = getMethodObj.ReturnJsonContent<SingleResourseModel>();
            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(200), "status code is not 200");

            //Проверка данных
            Assert.That(singleResourse.data.id, Is.EqualTo(2));
            Assert.That(singleResourse.data.name, Is.EqualTo("fuchsia rose"));
            Assert.That(singleResourse.data.year, Is.EqualTo(2001));
            Assert.That(singleResourse.data.color, Is.EqualTo("#C74375"));
            Assert.That(singleResourse.data.pantone_value, Is.EqualTo("17-2031"));
        }

        [Test]
        [DisplayName("Single Resourse not found")]
        public void GetMethodTest6()
        {

            var getMethodObj = new MethodGET();
            getMethodObj.SendGetMethod("unknown/23", client);

            var statusCode = getMethodObj.ReturnStatusCode();

            //Проверка статуса ответа
            Assert.That(statusCode, Is.EqualTo(404), "status code is not 404");
        }
    }
}