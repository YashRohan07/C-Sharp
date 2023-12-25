using SportsItemNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bashundhara_Kings_Management_System
{
    public class Football : SportsItem
    {
        private double radius;

        public Football() : base() { }

        public Football(string brand, double price, int quantity, double radius) : base(brand, price, quantity)
        {
            this.radius = radius;
        }

        public new void ShowItemInfo()
        {
            base.ShowItemInfo();
            Console.WriteLine("Radius: " + radius + " cm");
        }
    }

}
