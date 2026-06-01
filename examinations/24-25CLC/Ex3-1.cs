namespace Ex3_1
{
    public class SavingAccount
    {
        private double Balance;
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && Balance >= 150)
            {
                Balance -= amount;
            }
        }
        public double GetBalance()
        {
            return Balance;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount account = new SavingAccount();
            account.Deposit(250);
            account.Withdraw(50);
            Console.WriteLine("Current Balance: " + account.GetBalance());
            account.Withdraw(60);
            Console.WriteLine("Current Balance: " + account.GetBalance());
            account.Withdraw(10);
            Console.WriteLine("Current Balance: " + account.GetBalance());
        }
    }
}