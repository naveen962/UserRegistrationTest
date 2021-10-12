using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordTest
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
            [DataRow("Naveen@2897")]
            public void TestMethodPassword(string pass)
            {
                //Arrange
                bool expect = true;
                bool res;
                PasswordValidationUC8.ValidatePassword pwd = new PasswordValidationUC8.ValidatePassword();
                //Act
                res = pwd.PasswordCheck(pass);
                //Assert
                Assert.AreEqual(expect, res);
            }
        }
}
