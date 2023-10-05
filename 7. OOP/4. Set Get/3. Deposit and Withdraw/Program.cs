using System;

class BankAccount
{
    private double balance; // Private field to store the account balance

    // Public property to get and set the account balance
    public double Balance
    {
        get { return balance; } // Getter returns the balance
        private set // Private setter allows internal modification
        {
            if (value >= 0) 
            {
                balance = value;
            }
            else
            {
                Console.WriteLine("Invalid balance value.");
            }
        }
    }

    // Constructor to initialize the account with an initial balance
    public BankAccount(double initialBalance)
    {
        Balance = initialBalance; // Use the property to set the initial balance
    }

    // Method to deposit money into the account
    public void Deposit(double amount)
    {
        Balance += amount; // Use the property to update the balance
        Console.WriteLine($"Deposited ${amount}. New balance: ${Balance}");
    }

    // Method to withdraw money from the account
    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount; // Use the property to update the balance
            Console.WriteLine($"Withdrawn ${amount}. New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}

class Program
{
    static void Main()
    {
        // Create a bank account with an initial balance of $1000
        BankAccount account = new BankAccount(1000.0);

        account.Deposit(500.0);
        account.Withdraw(200.0);
        account.Withdraw(1500.0); 

        Console.ReadLine();
    }
}
