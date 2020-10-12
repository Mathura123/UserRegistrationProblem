using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UserRegistrationUTests
{
    [TestClass]
    public class UTests
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
        [TestMethod]
        public void Shukhla_Should_Return_Valid_Last_Name()
        {
            //Arrange
            string expectedResult = "Valid Last Name";
            string inputFirstName = "Shukhla";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.LastName(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void shukhla_Should_Return_Invalid_Last_Name()
        {
            //Arrange
            string expectedResult = "Invalid Last Name";
            string inputFirstName = "shukhla";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.LastName(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ram_at_gmail_dot_com_Should_Return_Valid_Email_Id()
        {
            //Arrange
            string expectedResult = "Valid Email Id";
            string inputFirstName = "ram@gmail.com";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.EmailId(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
