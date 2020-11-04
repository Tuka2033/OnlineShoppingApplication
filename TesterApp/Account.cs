
namespace Banking
{
    public class Account
    {

        private float balance;
        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public Account(float amount)
        {
            balance = amount;
        }
        public void Deposit(float amount)
        {
            balance = balance + amount;
        }
        public void Withdarw(float amount)
        {
            balance = balance - amount;
        }



        //is always overrided to convert object state into string 
        //
        public override string ToString()
        {
            return balance.ToString();
        }
    }
}
