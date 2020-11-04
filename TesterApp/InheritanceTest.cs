using System;
using HR;
 

namespace InheritanceDemo
{
  class InheritanceTest
    {
        static void Main(string[] args)
        { 
            DateTime birthdate = new DateTime(1975, 8, 18);
            Person thePerson = new Person("Ravi", "Tambade",birthdate);
            Console.WriteLine(thePerson);

            DateTime birthdate2 = new DateTime(1995, 5, 23);
            Employee emp = new Employee("Akash", "Bodhale", birthdate2,23,"R&D",12000,25);
            float salary = emp.CalculateSalary();
            Console.WriteLine(" Akash Salary = {0}", salary);


            DateTime birthdate3 = new DateTime(1995, 5, 23);
            Employee emp2 = new SalesEmployee("Vibhuti", "Trivedi", birthdate2, 25, "Projects", 13100, 28,5000);
            float salary2 = emp2.CalculateSalary();
            Console.WriteLine(" Vibhuti Salary = {0}", salary2);


            //Person prn = thePerson;  //instace of person

            //Person prn = emp;
            Person prn = emp2;
            //Polymorphism for Tostring will be worked....

            Console.WriteLine("Polymorphic Behaviour");
            Console.WriteLine(prn);
            Console.ReadLine();
        }
    }
}
