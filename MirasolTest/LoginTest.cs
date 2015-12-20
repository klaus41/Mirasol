using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MirasolProxy;
using DTOModel;

namespace MirasolTest
{
    [TestClass]
    public class LoginTest
    {
        [TestMethod]
        public void LoginTester()
        {
            User user = new User() { Email = "klausgaarde@live.dk", Password = "240789" };
            Facade facade = new Facade();
            bool expectedResult = true;
            bool testRestult = facade.GetLoginChecker().CheckCredentials(user); 
                
            
            Assert.AreEqual(expectedResult, testRestult);
        }
    }
}
