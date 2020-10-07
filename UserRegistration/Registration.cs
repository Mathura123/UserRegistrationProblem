using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Registration
    {
        string firstNameRegex = "^[A-Z][a-z]{2,}$";
        public bool validateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, firstNameRegex);
        }
    }
}
