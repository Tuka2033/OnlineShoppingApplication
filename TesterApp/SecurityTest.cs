using Membership;
using System;

namespace TesterApp
{
    class SecurityTest
    {

        static void Main(string [] args)
        {
            Console.WriteLine("Login Demo");
            Console.WriteLine("Enter User Id : ");
            string userId = Console.ReadLine();

            Console.WriteLine("Enter your Password : ");
            string password = Console.ReadLine();

            bool status = AccountManager.Login(userId, password);
            if (status)
            {
                Console.WriteLine("Welcome...");
            }
            else
            {
                Console.WriteLine("Invalid User....");
            }



            /// Unit Test for  Registration
            /// 



            Console.WriteLine("Customer Registration");
            Console.WriteLine("Full Name : ");
            string fullName = Console.ReadLine();

            Console.WriteLine("Enter your Email : ");
            string email = Console.ReadLine();


            Console.WriteLine("Enter your Contact Number : ");
            string contatNumber = Console.ReadLine();

            Console.WriteLine("Enter your Location : ");
            string location = Console.ReadLine();

            status = AccountManager.Register(userId, password, fullName, email, contatNumber, location);
            if (status)
            {
                Console.WriteLine("Test passsed....");
            }
            else
            {
                Console.WriteLine("Test failed....");

            }
            Console.ReadLine();

        }
    }
}
