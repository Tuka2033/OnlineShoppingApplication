using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{
    class BoxingUnBoxingTest
    {

        static void Main(string [] args)
        {

            //value type

            int count = 45;

            //reference type
            //Boxing is a technique where value type are transformed into reference type
            //Value type is wrapped in Refernce Type


            Object o = count;
            Console.Write(o);

            //Unboxing is a technique where reference type is unwrapped and value type is received.

            int result =(int) o;
            Console.WriteLine(result);
        }
    }
}
