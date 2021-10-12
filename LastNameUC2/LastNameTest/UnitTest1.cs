using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LastNameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Kumar")]
        public void TestMethodLastname(string lname)
        {
            //Arrange
            bool expect = true;
            bool res;
            LastNameUC2.ValidateLastname name = new LastNameUC2.ValidateLastname();
            //Act
            res = name.ValidateLastnameCheck(lname);
            //Assert
            Assert.AreEqual(expect, res);
        }
    }
}
