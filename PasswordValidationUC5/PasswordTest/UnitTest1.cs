using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Naveenkumar")]

        public void TestMethodPassword(string pass)
        {
            //Arrange
            bool expect = true;
            bool res;
            PasswordValidationUC5.ValidatePassword pwd = new PasswordValidationUC5.ValidatePassword();
            //Act
            res = pwd.PasswordCheck(pass);
            //Assert
            Assert.AreEqual(expect, res);
        }
    }
}
