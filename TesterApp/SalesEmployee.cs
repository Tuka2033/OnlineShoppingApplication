using System;

namespace HR
{
    //To block inheritnace always use keyword sealed
    public sealed class  SalesEmployee:Employee
    {
        public float Incentive { get; set; }
        public SalesEmployee(string fname, string lname,
                        DateTime bdate, int id,
                        string dept,
                        float bsalary, int daysWorked,float incentive):
            base(fname,lname,bdate,id,dept,bsalary,daysWorked)
        {
            Incentive = incentive;
        }

        public override float CalculateSalary()
        {
            return base.CalculateSalary() +Incentive;
        }

        public override string ToString()
        {
            return base.ToString() + " " + Incentive;
        }
    }
}
