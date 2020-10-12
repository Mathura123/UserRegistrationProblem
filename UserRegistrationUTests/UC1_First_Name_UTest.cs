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
    }
}
