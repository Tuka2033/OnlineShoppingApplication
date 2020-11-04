using System;


namespace HR
{


    // Deterministic Finalization

    public class Person:IDisposable
    {
        public Person()
        {
            this.FirstName = "";
            this.LastName = "";
            this.BirthDate = DateTime.Now;


            //initializing system resources at the time creation object

           // allocate system resoures which would be needed 
           // further for exeucteions
           // database connections,
           // mulitple threads,
           // files

        }
        public Person(string fname, string lname, DateTime bdate)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.BirthDate = bdate;



            //initializing system resources at the time creation object

            // allocate system resoures which would be needed 
            // further for exeucteions
            // database connections,
            // mulitple threads,
            // files


        }
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate + " ";
        }

        public void show() { 
        }

        public void Dispose()
        {
            //Deinitializing system resources  before object get Destroyed

            // Releaseing system resoures which were used 
            // 
            // database connections,
            // mulitple threads,
            // files

           GC.SuppressFinalize(this);
        }

        ~Person()
        {

            //Deinitializing system resources  before object get Destroyed

            // Releaseing system resoures which were used 
            // 
            // database connections,
            // mulitple threads,
            // files
        }
    }

}
