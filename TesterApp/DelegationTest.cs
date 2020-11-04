using System;
using Banking;

namespace TesterApp
{
        class DelegationTest
    {
        public static void PayIncomeTax()
        {
            Console.WriteLine(" 15%  income tax is deducted from your account");
        }
        public static void PayServiceTax()
        {
            Console.WriteLine(" 25%  service tax is deducted from your account");
        }
        public static void PayProfessionalTax()
        {
            Console.WriteLine(" 10%  Professional tax is deducted from your account");
        }

        static void Main(string [] args)
        {  //early Binding
           //PayIncomeTax();

            // late Binding

            AccountHandler operation1 = null;
            operation1=new AccountHandler(PayIncomeTax);  //registering name of function to be invoked 

            AccountHandler operation2 = null;
            operation2 = new AccountHandler(PayProfessionalTax);

            AccountHandler operation3 = null;
            operation3 = new AccountHandler(PayServiceTax);   //unicast delegate


            AccountHandler masterOperationManager = null;

            masterOperationManager = operation1;   //multicast 
            masterOperationManager += operation2;
            masterOperationManager += operation3;
           
            masterOperationManager();  // one invokation  ///multicast delegate


            Console.WriteLine("after unregistration");
            masterOperationManager -= operation3;
            masterOperationManager();  // one invokation  ///multicast delegate

            Console.ReadLine();
        }
    }
}
