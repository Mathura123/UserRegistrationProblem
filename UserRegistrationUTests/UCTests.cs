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
            string input= "Ram";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.FirstName(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ram_Should_Return_Inalid_First_Name()
        {
            //Arrange
            string expectedResult = "Invalid First Name";
            string input = "ram";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.FirstName(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Shukhla_Should_Return_Valid_Last_Name()
        {
            //Arrange
            string expectedResult = "Valid Last Name";
            string input = "Shukhla";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.LastName(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void shukhla_Should_Return_Invalid_Last_Name()
        {
            //Arrange
            string expectedResult = "Invalid Last Name";
            string input = "shukhla";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.LastName(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void Valid_Email_Id_Should_Return_Valid_Email_Id(string input)
        {
            //Arrange
            string expectedResult = "Valid Email Id";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.EmailId(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("abc.com")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void Invalid_Email_Id_Should_Return_Invalid_Email_Id(string input)
        {
            //Arrange
            string expectedResult = "Invalid Email Id";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.EmailId(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Valid_Mobile_No_Should_Return_Valid_Mobile_No()
        {
            //Arrange
            string expectedResult = "Valid Mobile No";
            string input = "0 8978675645";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.MobileNo(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Invalid_Mobile_No_Should_Return_Invalid_Mobile_No()
        {
            //Arrange
            string expectedResult = "Invalid Mobile No";
            string input = "8978675645";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.MobileNo(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void Valid_Password_Should_Return_Valid_Password()
        {
            //Arrange
            string expectedResult = "Valid Password";
            string input = "Pass@123word";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.Password(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        [DataRow("Pass@1")]
        [DataRow("pass@123word")]
        [DataRow("Pass@word")]
        [DataRow("Pass123word")]
        public void Invalid_Password_Should_Return_Invalid_Password(string input)
        {
            //Arrange
            string expectedResult = "Invalid Password";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.Password(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
