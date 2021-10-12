using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EmailTest
{
    [TestClass]
    public class UnitTest1
    {
       [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void TestMethodEmail(string email)
            {
                //Arrange
                bool expect = true;
                bool res;
                 EmailValidationSampleTestCase.ValidateEmail mail = new EmailValidationSampleTestCase.ValidateEmail();
                //Act
                res = mail.ValidateEmailCheck(email);
                //Assert
                Assert.AreEqual(expect, res);
            }
        }
}
