using System;

namespace UserRegistration
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to User Registration Problem in Main Branch");
            Registration user = new Registration();
        FirstName:
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            if (user.validateFirstName(firstName) == true)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Invalid First Name\nTry again");
                goto FirstName;
            }
        }
    }
}
