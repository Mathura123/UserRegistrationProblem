using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegistrationException :Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NO,
            INVALID_PASSWORD
        }
        private ExceptionType type;
        public UserRegistrationException(ExceptionType type,string message) : base(message)
        {
            this.type = type;
        }
    }
}
