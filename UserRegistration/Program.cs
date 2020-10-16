using System;

namespace UserRegistration
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to User Registration Problem in Main Branch");
            Registration user = new Registration();
            try
            {
                user.FirstName();
                user.LastName();
                user.EmailId();
                user.MobileNo();
                user.Password();
            }
            catch(UserRegistrationException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
