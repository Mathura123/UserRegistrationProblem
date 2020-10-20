using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Registration
    {
        string firstNameRegex = "^[A-Z][a-z]{2,}$";
        string lastNameRegex = "^[A-Z][a-z]{2,}$";
        string emailRegex = "^[a-zA-z0-9]+([-.+_][a-zA-Z0-9]+)*[@][a-zA-z0-9]+([.][a-zA-z]{2,}){1,2}$";
        string mobileNoRegex = "^[0-9]+[ ][1-9][0-9]{9}$";
        string passwordRegex = "^.*(?=.{8,}$)(?=.*[A-Z])(?=.*[0-9])(?=^[A-Za-z0-9]*[^a-zA-Z0-9][A-Za-z0-9]*$)";
        public Func<string, string, bool> Validation = (string detail, string regex) => Regex.IsMatch(detail, regex);
        public void FirstName()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            if (Validation(firstName,firstNameRegex))
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "Entered First Name is Invalid");
            }
        }
        public string FirstName(string firstName)
        {
            if (Validation(firstName, firstNameRegex))
            {
                return "Valid First Name";
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRST_NAME, "Entered First Name is Invalid");
            }
        }

        public void LastName()
        {
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            if (Validation(lastName, lastNameRegex))
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "Entered Last Name is Invalid");
            }
        }
        public string LastName(string lastName)
        {
            if (Validation(lastName, lastNameRegex))
            {
               return "Valid Last Name";
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LAST_NAME, "Entered Last Name is Invalid");
            }
        }

        public void EmailId()
        {
            Console.WriteLine("Enter your Email Id");
            string emailId = Console.ReadLine();
            if (Validation(emailId, emailRegex))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Entered Email is Invalid");
            }
        }
        public string EmailId(string emailId)
        {
            if (Validation(emailId, emailRegex))
            {
                return "Valid Email Id";
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Entered Email is Invalid");
            }
        }
        public void MobileNo()
        {
            Console.WriteLine("Enter your Mobile No");
            string mobileNo = Console.ReadLine();
            if (Validation(mobileNo, mobileNoRegex))
            {
                Console.WriteLine("Valid Mobile No");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NO, "Entered Mobile No is Invalid");
            }
        }
        public string MobileNo(string mobileNo)
        {
            if (Validation(mobileNo, mobileNoRegex))
            {
                return "Valid Mobile No";
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NO, "Entered Mobile No is Invalid");
            }
        }
        public void Password()
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (Validation(password, passwordRegex))
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Entered Password is Invalid");
            }
        }
        public string Password(string password)
        {
            if (Validation(password, passwordRegex))
            {
                return "Valid Password";
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Entered Password is Invalid");
            }
        }

        private bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, firstNameRegex);
        }
        private bool ValidateLastName(string lastName)
        {
            return Regex.IsMatch(lastName, lastNameRegex);
        }
        private bool ValidateEmailId(string email)
        {
            return Regex.IsMatch(email, emailRegex);
        }
        private bool ValidateMobileNo(string no)
        {
            return Regex.IsMatch(no, mobileNoRegex);
        }
        private bool ValidatePassword(string pass)
        {
            return Regex.IsMatch(pass, passwordRegex);
        }
    }
}
