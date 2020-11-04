using HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TesterApp
{

    enum Weekdays { Mon, Tue, Wed, Thu, Fri, Sat };
    enum Months { Jan, Feb, Mar, Apr, May,June, July, Aug, Sep, Oct, Nov, Dec};
    enum FavouriteColor {Red, Green, Yellow, Orange, Pink };


    class MathEngine
    {
        public const int  count = 56; // at the time of declaration you have to initialize
        public   readonly double PI;  //  you can delcare but no need to initaize here


        public MathEngine(int num1, int num2)
        {

            PI = 7.14;
        }
        public MathEngine()
        {
           // count = 67;

            PI = 3.14; //initialized only once.
        }

        public int Add(int op1, int op2)
        {
            //PI=45;

            return op1 + op2;


        }
    }
    class constreadonlyTest
    {

       

        static void ViewNames(params string[] names)
        {
          foreach( string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void  Swap(ref int n1, ref int n2)
        {
            int temp = n1; 
            n1 = n2;
            n2 = temp;
        }
        static void   Calculate(float radius, out float area, out float circum)
        {
            area = 3.14f * radius * radius;
            circum = 2 * 3.14f * radius;
        }

        static void Main(string [] args)
        {

            #region  Enum Examples

            Weekdays day = Weekdays.Wed;
            Months month = Months.Oct;
            FavouriteColor myColor = FavouriteColor.Orange;
            #endregion

            #region Collection Examples

            int[] schoolMarks;

            int[] marks = new int[9];

            int[] enggMarks = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] dacMarks = new int[] { 1, 2, 3, 4, 5, 6, 7, 9 };

            string []names = new string[] {"Ravi", "Akash", "Tanmay", "Gouri", "Asmita" };


            List<string> students = new List<string>();
            students.Add("Amitabh");
            students.Add("Rajesh");
            students.Add("Ramesh");
            students.Add("Ganesh");

            List<Person> people = new List<Person>();

            people.Add(new Person("Ravi", "Tambade", new DateTime(1975, 08, 18)));
            people.Add(new Person("Sameer", "Nene", new DateTime(1995, 08, 8))); 
            people.Add(new Person("Rajiv", "Gu[ta", new DateTime(1993, 03, 8)));

            foreach (Person prn in people)
            { 
                Console.WriteLine(prn); 
            }



            #endregion

            Console.WriteLine("{0}", day);

            #region MultipleViewNames
            ViewNames("Rahul Sir", "Bakul Madam", "Shrinivas Sir");
            ViewNames("Jeevan", "Sangita");
            ViewNames("Rahul Sir", "Bakul Madam", "Shrinivas Sir", "Rajesh", "Jay");
            #endregion


            int mumbaiPopulation = 45000;
            int punePopulation = 3400;
            Swap(ref mumbaiPopulation, ref punePopulation);

            float area;
            float circum;

            float radius = 4;

            Calculate(radius, out area, out circum);


            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Circumference= {0}", circum);


            Console.ReadLine();
        }
    }
}
