using Bashundhara_Kings_Management_System;
using CustomerNamespace;
using SportsNamespace;
using System;

namespace BashundharaKingsManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            CricketBat cricketBat = new CricketBat("MRF", 5000, 10, 5.5, 6.6);
            Customer cricketCustomer = new Customer("Virat Kohli", 2, 10000);
            Console.WriteLine("Cricket Bat Information:");
            Console.WriteLine("Customer Name: " + cricketCustomer.GetCustomerName());
            Console.WriteLine("Total Items: " + cricketCustomer.GetNoOfItem());
            Console.WriteLine("Total Payment: " + cricketCustomer.GetTotalPay());
            cricketBat.ShowInfo();
            Console.WriteLine();

            Football football = new Football("Adidas", 6000, 20, 4.5);
            Customer footballCustomer = new Customer("Ronaldo", 3, 20000);
            Console.WriteLine("Football Information:");
            Console.WriteLine("Customer Name: " + footballCustomer.GetCustomerName());
            Console.WriteLine("Total Items: " + footballCustomer.GetNoOfItem());
            Console.WriteLine("Total Payment: " + footballCustomer.GetTotalPay());
            football.ShowItemInfo();

            Console.ReadLine();
        }
    }
}
