using System;
using HR;

namespace TesterApp
{
    class GCTest
    { 
        static void Main(string [] args)
        {


            //Deterministic Finalization------explicitly disposing resources by main thread
            //InDeterministic Finalzation----- calling destructor for releasing resources by GC

            using (Person thePerson = new Person("Ravi", "Tambade", new DateTime(1975, 08, 18)))
            {

                for (int i = 0; i < 5000; i++)
                {
                    // Person thePerson = new Person("Ravi"+i, "Tambade", new DateTime(1975, 08, 18));
                    //Console.WriteLine(thePerson);
                    thePerson.show();

                }
            }

            //GC.SuppressFinalize(thePerson);
            //GC.WaitForPendingFinalizers();
           // GC.Collect();
            Console.ReadLine();

        }
    }
}
