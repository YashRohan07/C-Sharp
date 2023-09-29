/* Write a program that asks the users to type the price without tax of one kilogram o potatoes,
 the number of kilograms you want to buy and the tax in percent unit. */
using System;

namespace Lab_Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the price without tax of one kilogram of potatoes: ");
            double pricePerKg = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of kilogram you want to buy: ");
            double kilogramsToBuy = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the tax rate in percent: ");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            double totalPriceWithoutTax = pricePerKg * kilogramsToBuy;
            double taxAmount = (taxRate / 100) * totalPriceWithoutTax;
            double totalPriceWithTax = totalPriceWithoutTax + taxAmount;

            Console.WriteLine("Total cost without tax: " + totalPriceWithoutTax);
            Console.WriteLine("Tax amount: " + taxAmount);
            Console.WriteLine("Total cost with tax: " + totalPriceWithTax);

            Console.ReadLine();
        }
    }
}
