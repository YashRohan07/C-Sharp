using SportsItemNamespace;
using System;

namespace SportsNamespace
{
    public class CricketBat : SportsItem
    {
        private double height;
        private double width;

        public CricketBat() : base() { }

        public CricketBat(string brand, double price, int quantity, double height, double width) : base(brand, price, quantity)
        {
            this.height = height;
            this.width = width;
        }

        public void ShowInfo()
        {
            ShowItemInfo();
            Console.WriteLine("Height: " + height + " cm");
            Console.WriteLine("Width: " + width + " cm");
        }
    }
}
