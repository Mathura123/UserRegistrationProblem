using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Registration
    {
        string firstNameRegex = "^[A-Z][a-z]{2,}$";
        string lastNameRegex = "^[A-Z][a-z]{2,}$";
        string emailRegex = "^[a-zA-z0-9]+(.[a-zA-Z0-9]+)*@[a-zA-z0-9]+(.[a-zA-z]+)+$";
        string mobileNoRegex = "^[0-9]+[ ][1-9][0-9]{9}$";
        string passwordRegex = "^.{8,}$";
        public void FirstName()
        {
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            if (ValidateFirstName(firstName) == true)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name\nTry again");
                FirstName();
            }
        }
        public void LastName()
        {
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            if (ValidateLastName(lastName) == true)
            {
                Console.WriteLine("Valid Last Name");
            }
            else
            {
                Console.WriteLine("Invalid Last Name\nTry again");
                LastName();
            }
        }
        public void EmailId()
        {
            Console.WriteLine("Enter your Email Id");
            string emailId = Console.ReadLine();
            if (ValidateEmailId(emailId) == true)
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id\nTry again");
                EmailId();
            }
        }
        public void MobileNo()
        {
            Console.WriteLine("Enter your Mobile No");
            string mobileNo = Console.ReadLine();
            if (ValidateMobileNo(mobileNo) == true)
            {
                Console.WriteLine("Valid Mobile No");
            }
            else
            {
                Console.WriteLine("Invalid Mobile No\nTry again");
                MobileNo();
            }
        }
        public void Password()
        {
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (ValidatePassword(password) == true)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password\nTry again");
                Password();
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
