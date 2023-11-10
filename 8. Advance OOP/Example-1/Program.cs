using System;

public class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string TelephoneNumber { get; set; }
}

public class Customer : Person
{
    public int CustomerNumber { get; set; }
    public bool MailingList { get; set; }
}

public class PreferredCustomer : Customer
{
    public double TotalPurchases { get; set; }
    public double DiscountLevel { get; private set; }

    public void CalculateDiscount()
    {
        if (TotalPurchases >= 2000)
        {
            DiscountLevel = 0.07;
        }
        else if (TotalPurchases >= 1500)
        {
            DiscountLevel = 0.05;
        }
        else if (TotalPurchases >= 1000)
        {
            DiscountLevel = 0.02;
        }
        else if (TotalPurchases >= 500)
        {
            DiscountLevel = 0.01;
        }
        else
        {
            DiscountLevel = 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        PreferredCustomer customer1 = new PreferredCustomer
        {
            Name = "Yash Rohan",
            Address = "Meherpur",
            TelephoneNumber = "1234567890",
            CustomerNumber = 12345,
            MailingList = true,
            TotalPurchases = 1500
        };

        customer1.CalculateDiscount();

        Console.WriteLine("Customer Information:");
        Console.WriteLine($"Name: {customer1.Name}");
        Console.WriteLine($"Address: {customer1.Address}");
        Console.WriteLine($"Telephone Number: {customer1.TelephoneNumber}");
        Console.WriteLine($"Customer Number: {customer1.CustomerNumber}");
        Console.WriteLine($"On Mailing List: {customer1.MailingList}");
        Console.WriteLine($"Total Purchases: {customer1.TotalPurchases} TK");
        Console.WriteLine($"Discount Level: {customer1.DiscountLevel * 100}%");

        Console.ReadLine();
    }
}

/*
 Output:

Customer Information:
Name: Yash Rohan
Address: Meherpur
Telephone Number: 1234567890
Customer Number: 12345
On Mailing List: True
Total Purchases: 1500 TK
Discount Level: 5%


After the CalculateDiscount method has determined the appropriate discount for the customer,
the line Console.WriteLine($"Discount Level: {customer1.DiscountLevel * 100}%"); prints this information
 */