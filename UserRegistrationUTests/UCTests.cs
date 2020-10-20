using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

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
            string input = "Ram";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            //Act
            string result = regObj.FirstName(input);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
        [TestMethod]
        public void ram_Should_Return_Invalid_First_Name()
        {
            try
            {
                string input = "ram";
                UserRegistration.Registration regObj = new UserRegistration.Registration();

                string result = regObj.FirstName(input);
            }
            catch (UserRegistrationException e)
            {
                string expectedResult = "Entered First Name is Invalid";
                Assert.AreEqual(e.Message, expectedResult);
            }
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
            try
            {
                string input = "shukhla";
                UserRegistration.Registration regObj = new UserRegistration.Registration();

                string result = regObj.LastName(input);
            }
            catch (UserRegistrationException e)
            {
                string expectedResult = "Entered Last Name is Invalid";
                Assert.AreEqual(e.Message, expectedResult);
            }
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
            string expectedResult = "Valid Email Id";
            UserRegistration.Registration regObj = new UserRegistration.Registration();

            string result = regObj.EmailId(input);
            Assert.AreEqual(result, expectedResult);
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
            try
            {
                UserRegistration.Registration regObj = new UserRegistration.Registration();

                string result = regObj.EmailId(input);
            }
            catch (UserRegistrationException e)
            {
                string expectedResult = "Entered Email is Invalid";

                Assert.AreEqual(e.Message, expectedResult);
            }

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
            try
            {
                string input = "8978675645";
                UserRegistration.Registration regObj = new UserRegistration.Registration();

                string result = regObj.MobileNo(input);
            }
            catch (UserRegistrationException e)
            {

                string expectedResult = "Entered Mobile No is Invalid";

                Assert.AreEqual(expectedResult, e.Message);
            }
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
            try
            {
                UserRegistration.Registration regObj = new UserRegistration.Registration();

                string result = regObj.Password(input);
            }
            catch (UserRegistrationException e)
            {
                string expectedResult = "Entered Password is Invalid";
                Assert.AreEqual(expectedResult, e.Message);
            }
        }
        [TestMethod]
        [DataRow("Ram", "^[A-Z][a-z]{2,}$")]//Valid First Name with firstNameRegex
        [DataRow("Shukhla", "^[A-Z][a-z]{2,}$")]//Valid Last Name with lastNameRegex
        [DataRow("abc@yahoo.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]//Valid Email Ids with emailRegex
        [DataRow("abc-100@yahoo.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc-100@yahoo.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc-100@yahoo.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc-100@yahoo.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc.100@abc.com.au", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@1.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@gmail.com.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc+100@gmail.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("0 8978675645", "^[0-9]+[ ][1-9][0-9]{9}$")]//Valid Mobile No with mobileNoRegex
        [DataRow("Pass@123word", "^.*(?=.{8,}$)(?=.*[A-Z])(?=.*[0-9])(?=^[A-Za-z0-9]*[^a-zA-Z0-9][A-Za-z0-9]*$)")]//Valid Password with passwordRegex
        public void Valid_Details_Should_Return_True_In_Validate_Lambda_Function(string detail,string regex)
        {
            bool expected = true;
            Registration registrationObj = new Registration();
            bool result = registrationObj.Validation(detail, regex);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [DataRow("ram", "^[A-Z][a-z]{2,}$")]//Invalid First Name with firstNameRegex
        [DataRow("shukhla", "^[A-Z][a-z]{2,}$")]//Invalid Last Name with lastNameRegex
        [DataRow("abc.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]//Invalid Email Ids with emailRegex
        [DataRow("abc123@gmail.a", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc123@.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@.com.my", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc123@.com.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow(".abc@abc.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc()*@gmail.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@%*.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc..2002@gmail.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc.@gmail.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@abc@gmail.com", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@gmail.com.1a", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("abc@gmail.com.aa.au", "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$")]
        [DataRow("8978675645", "^[0-9]+[ ][1-9][0-9]{9}$")]//Invalid Mobile No with mobileNoRegex
        [DataRow("Pass@1", "^.*(?=.{8,}$)(?=.*[A-Z])(?=.*[0-9])(?=^[A-Za-z0-9]*[^a-zA-Z0-9][A-Za-z0-9]*$)")]//Invalid Passwords with passwordRegex
        [DataRow("pass@123word", "^.*(?=.{8,}$)(?=.*[A-Z])(?=.*[0-9])(?=^[A-Za-z0-9]*[^a-zA-Z0-9][A-Za-z0-9]*$)")]
        [DataRow("Pass@word", "^.*(?=.{8,}$)(?=.*[A-Z])(?=.*[0-9])(?=^[A-Za-z0-9]*[^a-zA-Z0-9][A-Za-z0-9]*$)")]
        [DataRow("Pass123word", "^.*(?=.{8,}$)(?=.*[A-Z])(?=.*[0-9])(?=^[A-Za-z0-9]*[^a-zA-Z0-9][A-Za-z0-9]*$)")]
        public void Invalid_Details_Should_Return_False_In_Validate_Lambda_Function(string detail, string regex)
        {
            bool expected = false;
            Registration registrationObj = new Registration();
            bool result = registrationObj.Validation(detail, regex);
            Assert.AreEqual(expected, result);
        }
    }
}
