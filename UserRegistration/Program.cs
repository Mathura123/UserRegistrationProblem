using System;

namespace UserRegistration
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to User Registration Problem in Main Branch");
            Registration user = new Registration();
            user.FirstName();
            user.LastName();
            user.EmailId();
        }
    }
}
