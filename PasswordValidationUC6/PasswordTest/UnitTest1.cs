using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("naveenkumar")]

        public void TestMethodPassword(string pass)
        {
            //Arrange
            bool expect = true;
            bool res;
            PasswordValidationUC6.ValidatePassword pwd = new PasswordValidationUC6.ValidatePassword();
            //Act
            res = pwd.PasswordCheck(pass);
            //Assert
            Assert.AreNotEqual(expect, res);
        }
    }
}
