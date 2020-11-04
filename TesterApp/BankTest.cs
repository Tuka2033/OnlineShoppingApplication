
using Banking;
using System;

namespace TesterApp
{
    class BankTest
    {
        static void Main(string []args)
        {
            Account acct1 = new Account(56000);
            Console.WriteLine("1.withdraw");
            Console.WriteLine("2.deposit");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Amount :");
            float amount = float.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        acct1.Withdarw(amount);
                    }
                    break;
                case 2:
                    {
                        acct1.Deposit(amount);
                    }
                    break;

            }
            float balance = acct1.Balance;
            Console.WriteLine("Your remaining Balance= {0}", balance);

            Console.WriteLine(acct1);
           Console.ReadLine();
        }
    }
}
