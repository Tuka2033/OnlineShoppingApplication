using System;
using Catalog;


namespace TesterApp
{


    class Program
    {
        private string programName;

        //Property : This concept is took from Visual Basic

        public string Name
        {
            get { return programName; }
            set { programName = value; }  //value keyword is inbuilt provided by C#
        }
      
         public  Program()
        {
            this.programName = "FirstProgram";
        }

        public Program(string name)
        {
            this.programName = name;
        }

        //Entry  Point

        static void Main(string[] args) // string array represent command line argument
        {
            //Command line Argument processing

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Hello World !" + args[i]);
            }
           
            Console.WriteLine("Welcome to Dotnet Programming");
            int count = 45;   // background of C , C++
            count = count++;
            count = count + 1;


            if(count <= 300)
            {
                while(count < 299)
                {
                    Console.WriteLine("count = {0}", count);
                    count++;
                }
            }

            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("Good morning" + name);
            Console.WriteLine("Good morning {0}", name);  //{} place holder


            //var marks = 567;

            //This is fantastic programming language
            /*I like both commenting style */


            int result = Addition(65, 67);
            int result2 = Multiplication(4, 6);

            Program theProgram = new Program();
            theProgram.Name = "My Best Program";

            Console.WriteLine("PRogram title=" + theProgram.Name);

            theProgram.Display();

            Product theProduct1 = new Product(1, "Gerbera", "Wedding Flower", 4500, 10);
            Product theProduct2 = new Product(2, "Rose", "Valentine Flower", 400, 20);

            Console.WriteLine(theProduct1);
            Console.ReadLine();
        }
        static  int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

        //Member function


        //access specifiers in C#
        //public, private, protected, internal (Assembly Scope)

        public void Display()
        {
            Console.WriteLine("Processing logic for Dispaly");
            Console.WriteLine("Program instance Dashboard......");
        }
    }
}
