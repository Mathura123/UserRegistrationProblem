using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationUTests
{
    [TestClass]
    public class UC1_First_Name_UTest
    {
        [TestMethod]
        public void Ram_Should_Return_Valid_First_Name()
        {
            //Arrange
            string expectedResult = "Valid First Name";
            string inputFirstName = "Ram";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.FirstName(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ram_Should_Return_Inalid_First_Name()
        {
            //Arrange
            string expectedResult = "Invalid First Name";
            string inputFirstName = "ram";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.FirstName(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
