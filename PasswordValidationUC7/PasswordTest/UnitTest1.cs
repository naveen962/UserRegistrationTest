using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Naveen28")]
        public void TestMethodPassword(string pass)
        {
            //Arrange
            bool expect = true;
            bool res;
            PasswordValidationUC7.ValidatePassword pwd = new PasswordValidationUC7.ValidatePassword();
            //Act
            res = pwd.PasswordCheck(pass);
            //Assert
            Assert.AreEqual(expect, res);
        }
    }
}
