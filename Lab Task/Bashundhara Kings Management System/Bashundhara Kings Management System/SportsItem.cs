using System;

namespace SportsItemNamespace
{
    public class SportsItem
    {
        private string brand;
        private double price;
        private int quantity;
        public SportsItem() { }
        public SportsItem(string brand, double price, int quantity)
        {
            this.brand = brand;
            this.price = price;
            this.quantity = quantity;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }
        public double GetPrice()
        {
            return price;
        }
        public string GetBrand()
        {
            return brand;
        }

        public int GetQuantity()
        {
            return quantity;
        }

       
        public void ShowItemInfo()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price: $" + price);
            Console.WriteLine("Quantity: " + quantity);
        }
    }

   
}
