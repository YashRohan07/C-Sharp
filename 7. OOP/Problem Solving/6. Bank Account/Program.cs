using System;

namespace Account
{
    class Account
    {
        public string accName { get; set; }
        public string acId { get; set; }
        public int balance { get; set; }

        public Account() { }

        public Account(string AccountName, string AccountId, int AccounBalance)
        {
            accName = AccountName;
            acId = AccountId;
            balance = AccounBalance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount}, Then New Balance: ${balance}");
        }

        public void Withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}, Then New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }

        public void Transfer(int amount, Account receiver)
        {
            if (amount <= balance)
            {
                balance -= amount;
                receiver.Deposit(amount);
                Console.WriteLine($"Transferred ${amount} , New Balance: ${balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance for Transfer.");
            }
        }

        static void Main(string[] args)
        {
            Account senderAccount = new Account("Yash", "1", 5000);
            Account receiverAccount = new Account("Rohan", "2", 3000);

            senderAccount.Deposit(2000);
            senderAccount.Withdraw(3000);
            senderAccount.Transfer(1000, receiverAccount);

            Console.ReadLine();
        }
    }
}
