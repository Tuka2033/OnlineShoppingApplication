using HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesterApp
{

    public struct Point
    {
        public int x;
        public int y;

    }


    //Abstract class enforce  overriding

    public abstract class Shape
    {
        //Minimum one method has to be abstract method
        abstract public void Draw();
        public string Color { get; set; }
        public string Width { get; set; }
        public void Display()
        {
            Console.WriteLine("Shape is getting displayed....");
        }
    }

    public class Line : Shape
    {
        public Point StartPoint;
        public Point EndPoint;
        public override void Draw()
        {
            Console.WriteLine("Line is drawn...");
            Console.WriteLine("First Point {0}, {1}", StartPoint.x, StartPoint.y);
            Console.WriteLine("Second Point {0}, {1}", EndPoint.x, EndPoint.y);
            Console.WriteLine("Color ={0} ", Color);
            Console.WriteLine("Width ={0} ", Width);
        }
    }




    //Proto type
    // is used to define contract
    // is used to define specification
    // is used to define guidlines
    // is used to enforce rules while building concrete  classes.

    //Printing is a skill, a capaility

    interface IPrintable
    {
        void Print();
        void Start();
        void Stop();
    }

    interface IScannable
    {
        void Scan();
    }

    //Proto type is implemented by concrete class

    class Printer : IPrintable,IScannable   //Multiple Interface inheritance
    {
        public void Scan()
        {
            Console.WriteLine("Started  scanning document.....");
        }

        public void Start()
        {
            Console.WriteLine("Printer is started....");
        }

        public void Stop()
        {
            Console.WriteLine("Printer has stopped working...");

        }

        void IPrintable.Print()
        {
            Console.WriteLine("Printing data");
        }
    }

    class ThreeDPrinter:IPrintable,IScannable
    {
        public void Scan()
        {
            Console.WriteLine("Started  scanning  3D Object using  UV camera");
        }

        public void Start()
        {
            Console.WriteLine("3D Printer has started initializeing material needed to Job creation.");
        }

        public void Stop()
        {
            Console.WriteLine("3D Printer has stopped building Model......");
        }

        void IPrintable.Print()
        {
            Console.WriteLine(" Building 3-D model..........");
        }
     }


    class LanguageFeaturesTest
    {

        static void Main(string [] args)
        {

            //value types:
            //values of value type are stored on stack 
            //primitive
            int result = 12;
            float price = 45;
            bool status = false;
            double score = 5600;


            //Reference types

            //class,
            // are of two types
            // concrete class and abstract class

            //interface, delegate, event
            //values pointed by reference type are always store on Heap

            //Heap is managed by Garbage Collector;


            Console.WriteLine("Demo for Interfae inheritance");
            IPrintable outputDevice = null;

          
            outputDevice = new Printer();  // runtime

            //late binding
            outputDevice.Start();
            outputDevice.Print();  // Printer method will be invoked
            outputDevice.Stop();

         
            outputDevice = new ThreeDPrinter();


            //Doing ordinary things , extra ordinarily


            //early binding: resolving function at compile time
            //late binding  : resolving function at runtime
            
            outputDevice.Start();
            outputDevice.Print();  // ThreeDPrinter method will be invoked
            outputDevice.Stop();

            LanguageFeaturesTest test = new LanguageFeaturesTest();


            Console.Write("Demo Abstract class");

            Shape theShape = new Line();

            theShape.Color = "Red";
            theShape.Width = "4";

            Line l =  theShape as Line;

            l.StartPoint = new Point();
            l.StartPoint.x = 78;
            l.StartPoint.y = 12;

            l.EndPoint = new Point();
            l.EndPoint.x = 56;
            l.EndPoint.y = 12;


            theShape.Draw();

            Console.WriteLine("Welcome to C#");
            Console.ReadLine();
        }
    }
}
