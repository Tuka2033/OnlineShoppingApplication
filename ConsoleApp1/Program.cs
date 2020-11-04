using System;
using System.Collections.Generic;

using MathLib;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {

            int num1 = 34;
            int num2 = 56;

            int realResult = MathEngine.Addition(num1, num2);
            Console.WriteLine("Result= {0}", realResult);


            Complex c1 = new Complex(23, 54);
            Complex c2 = new Complex(100, 44);
            Complex c3 = new Complex();


            c3 = c1 + c2;



            Console.ReadLine();

        }
    }
}
