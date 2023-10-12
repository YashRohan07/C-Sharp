using System;

namespace Array_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] car = new string[3]; // Create an array of 3 elements and add values later
            string[] bike = new string[3] { "Pulsar", "Yamaha", "Dominar" }; // Create an array of 3 elements and add values right away
            string[] color = new string[] { "Black", "White", "Red" }; // Create an array of 3 elements without specifying the size
            string[] teams = { "Aus", "Eng", "Ind" }; // Create an array of 3 elements, omitting the new keyword

            // Add values to the "car" array
            car[0] = "Toyota";
            car[1] = "Honda";
            car[2] = "Ford";

            // Print the contents of each array
            Console.WriteLine("car: " + string.Join(", ", car));
            Console.WriteLine("bike: " + string.Join(", ", bike));
            Console.WriteLine("color: " + string.Join(", ", color));
            Console.WriteLine("teams: " + string.Join(", ", teams));

            Console.ReadLine();
        }
    }
}
