using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestRegex
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Naveen")]
       
        public void TestMethodFirstname(string fname)
        {
            //Arrange
            bool expect = true;
            bool res;
            FirstNameUC1.ValidateFirstName name = new FirstNameUC1.ValidateFirstName();
            //Act
            res=name.firstNameCheck(fname);
            //Assert
            Assert.AreEqual(expect, res);
        }
    }
}
