using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("abc.xyz@bl.co.in")]
     
          

            public void TestMethodEmail(string email)
            {
                //Arrange
                bool expect = true;
                bool res;
                EmailUC3.ValidateEmail mail = new EmailUC3.ValidateEmail();
                //Act
                res = mail.ValidateEmailCheck(email);
                //Assert
                Assert.AreEqual(expect, res);
            }
        
    }
}
