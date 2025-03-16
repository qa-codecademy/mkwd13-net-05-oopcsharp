namespace Qinshift.Task_3.Models
{
    public class Customer
    {
        public string FullName { get; private set; }
        public long CardNumber { get; private set; }
        private int Pin { get; set; }
        private decimal Balance { get; set; }

        public Customer(string fullName, long cardNumber, int pin, decimal balance)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }

        public bool Authenticate(int pin)
        {
            return Pin == pin;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }

}
