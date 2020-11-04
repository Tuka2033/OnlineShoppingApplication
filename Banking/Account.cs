namespace Banking
{
    // delegate definition
    public delegate void AccountHandler();

    public class Account
    {
        // Can class have state, behaviour 

        private float balance;   //state
        public event AccountHandler underbalance;  //event
        public event AccountHandler overbalance;   //event


        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }


        // static behaviour

        public Account(float amount)
        {
            balance = amount;
        }


        // condition

        public void Monitor()   // Observing  Balance
        {
            //Check balance against threshhold
            if(balance < 5000)
            {
                // raise an event underbalance
                // trigger
                underbalance();  //invoking event
            }
            else if (balance >= 250000)
            {
                // raise an event overbalance
                //trriger
                overbalance();  //invoking event
            }
        }
        public void Deposit(float amount)
        {
            balance = balance + amount;
            Monitor();
        }
        public void Withdarw(float amount)
        {
            balance = balance - amount;
            Monitor();
        }

        // dynamic behviour
        // underblance, overbalane as events


        //is always overrided to convert object state into string 
        //
        public override string ToString()
        {
            return balance.ToString();
        }
    }
}