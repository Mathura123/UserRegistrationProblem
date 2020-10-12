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
        [TestMethod]
        public void ram_at_gmail_dot_com_dot_123_Should_Return_Invalid_Email_Id()
        {
            //Arrange
            string expectedResult = "Invalid Email Id";
            string inputFirstName = "ram@gmail.com.123";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.EmailId(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Valid_Mobile_No_Should_Return_Valid_Mobile_No()
        {
            //Arrange
            string expectedResult = "Valid Mobile No";
            string inputFirstName = "0 8978675645";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.MobileNo(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Invalid_Mobile_No_Should_Return_Invalid_Mobile_No()
        {
            //Arrange
            string expectedResult = "Invalid Mobile No";
            string inputFirstName = "8978675645";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.MobileNo(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Pass_at_123word_Should_Return_Valid_Password()
        {
            //Arrange
            string expectedResult = "Valid Password";
            string inputFirstName = "Pass@123word";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.Password(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Pass_at_1_Should_Return_Invalid_Password()
        {
            //Arrange
            string expectedResult = "Invalid Password";
            string inputFirstName = "Pass@1";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.Password(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void pass_at_123word_Should_Return_Invalid_Password()
        {
            //Arrange
            string expectedResult = "Invalid Password";
            string inputFirstName = "pass@123word";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.Password(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Pass_at_word_Should_Return_Invalid_Password()
        {
            //Arrange
            string expectedResult = "Invalid Password";
            string inputFirstName = "Pass@word";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.Password(inputFirstName);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
