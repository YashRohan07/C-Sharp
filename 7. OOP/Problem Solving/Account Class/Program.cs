using System;
using System.Collections.Generic;

// Account class
class Account
{
    public int accId; // Account ID
    public string accName; // Account Name
    public double accBalance; // Account Balance

    // Constructor to initialize account details
    public Account(int id, string name, double balance)
    {
        accId = id;
        accName = name;
        accBalance = balance;
    }

    // Method to display account information
    public void showInfo()
    {
        Console.WriteLine("Account ID: " + accId);
        Console.WriteLine("Account Name: " + accName);
        Console.WriteLine("Account Balance: " + accBalance);
    }

    // List of transactions associated with the account
    public List<Transaction> listOfTransaction = new List<Transaction>();

    // Total number of transactions
    public int totalNumberOfTransaction;

    // Method to add a new transaction
    public void addTransaction(Account sender, Account receiver, int amount)
    {
        Transaction transaction = new Transaction(sender, receiver, amount);
        listOfTransaction.Add(transaction);
        totalNumberOfTransaction++;
    }

    // Method to show all transactions
    public void showAllTransaction()
    {
        foreach (Transaction transaction in listOfTransaction)
        {
            transaction.showInfo();
        }
    }
}

// Transaction class
class Transaction
{
    public Account sender; // Sender's account
    public Account receiver; // Receiver's account
    public int amount; // Transaction amount
    public string additionalInfo; // Additional information about the transaction

    // Constructor to initialize transaction details
    public Transaction(Account sender, Account receiver, int amount)
    {
        this.sender = sender;
        this.receiver = receiver;
        this.amount = amount;
    }

    // Method to display transaction information
    public void showInfo()
    {
        Console.WriteLine("Sender: " + sender.accName);
        Console.WriteLine("Receiver: " + receiver.accName);
        Console.WriteLine("Amount: " + amount);
        Console.WriteLine("Additional Info: " + additionalInfo);
    }
}

// Main class
class Program
{
    static void Main()
    {
        // Creating accounts
        Account account1 = new Account(1, "John", 5000);
        Account account2 = new Account(2, "Doe", 3000);

        // Adding transactions
        account1.addTransaction(account1, account2, 1000);
        account2.addTransaction(account2, account1, 500);

        // Displaying account information
        Console.WriteLine("Account 1 Information:");
        account1.showInfo();
        Console.WriteLine("\nAccount 2 Information:");
        account2.showInfo();

        // Displaying all transactions
        Console.WriteLine("\nAll Transactions:");
        account1.showAllTransaction();
    }
}
