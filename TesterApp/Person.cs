using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{

    //User defined structure Type
   
    public class Person
    {
        public Person() {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now ;
        }
        public Person(string fname, string lname,DateTime bdate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = bdate;
        }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDate {get;set;}


        public override string ToString()
        {
            return FirstName + " " + LastName+ " " + BirthDate + " " ;
        }
    }
}
