using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PhonenoTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethodPhone()
        {
            //Arrange
            string phno = "918277284163";
            bool expect = true;
            bool res;
            ValidatePhoneNoUC4.ValidatePhno phone = new ValidatePhoneNoUC4.ValidatePhno();
            //Act
            res = phone.PhoneCheck(phno);
            //Assert
            Assert.AreEqual(expect, res);
        }
    }
}
