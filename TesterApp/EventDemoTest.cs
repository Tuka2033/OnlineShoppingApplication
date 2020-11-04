using System;
using Banking;
namespace TesterApp
{



    // Subscriber 1

     public static class Government
    {

        // will always contain handlers
        public static void PayIncomeTax() {
            Console.WriteLine("25% income tax is getting deducted from your account");
        }

        public static void SetIncomeTaxEnquiry()
        {
            Console.WriteLine("Income Tax offficals have been informed to enquire about payee as well as register arrest warrant");
        }

    }


    //Subscriber 2
    public static   class HDFCBank
    {
        public static void BlockAccount()
        {
            Console.WriteLine("Your account has been blockd due to insufficient funds");
        }

        public static void SendEmail()
        {
            Console.WriteLine("Banking operations details are sent to your registered email id");
        }

    }


    class EventDemoTest
    {
        static void Main(string [] args)
        { 

            //Observer pattern

            // Event Driven Mechanism apply

            // Define delegate AccountHandler
            // Define your class with events  based on delegagte
            // Write a logic to raise events based on conditions.
            // Defined Event handler logic  for events

            // Register EventHandlers with events before method invokation
            // Invoke basic operations against isntance (Account )


            //Programs behaviour is gets  decided based on events defined,
            //                                             event handler logic implemented
            //                                             condition set for event triggering logic
            Account acct = new Account(45000);


            //events are getting registered  with event handlers


            //Subscribe to account 
            acct.underbalance += new AccountHandler(HDFCBank.BlockAccount);// register
            acct.underbalance += new AccountHandler(HDFCBank.SendEmail);// register

            acct.overbalance += new AccountHandler(Government.PayIncomeTax); // register
            acct.overbalance += new AccountHandler(Government.SetIncomeTaxEnquiry); //register


            Console.WriteLine("Initial Balance = {0}",acct.Balance);
            Console.WriteLine("Enter Amount to Withdraw : ");
            float amount = float.Parse(Console.ReadLine());

            acct.Deposit(amount);
            Console.WriteLine("Net Balance after operation : ");
            Console.WriteLine(acct.Balance);
            Console.ReadLine();
        }
    }
}
