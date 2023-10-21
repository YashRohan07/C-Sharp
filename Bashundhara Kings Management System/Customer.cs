using System;

namespace CustomerNamespace
{
    public class Customer
    {
        private string customerName;
        private int noOfItem;
        private double totalPay;

        public Customer() { }
        
        public Customer(string customerName, int noOfItem, double totalPay)
        {
            this.customerName = customerName;
            this.noOfItem = noOfItem;
            this.totalPay = totalPay;
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public int GetNoOfItem()
        {
            return noOfItem;
        }

        public double GetTotalPay()
        {
            return totalPay;
        }

        public void ShowCustomerInfo()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Number of Items: " + noOfItem);
            Console.WriteLine("Total Payment: $" + totalPay);
        }
    }

    
}
