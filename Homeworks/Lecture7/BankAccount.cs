namespace Lecture7
{
    class BankAccount
    {
        public string AccountNumber;
        public decimal Balance;

        public BankAccount(string number, decimal balance)
        {
            AccountNumber = number;
            Balance = balance;

        }

        public void Deposit(decimal amountToAdd)
        {
            Balance += amountToAdd;
        }

        public void Withdraw(decimal amountToSubtract)
        {
            if (Balance < amountToSubtract)
            {
                throw new InsufficientFundsException("Withdrawal amount exceeds the current balance.");
            }
        }
    }
}