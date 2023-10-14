using System;
using System.Xml.Linq;

namespace Array_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bike = new string[3] { "Pulsar", "Yamaha", "Dominar" }; // Create an array of 3 elements and add values right away
            string[] color = new string[] { "Black", "White", "Red" }; // Create an array of 3 elements without specifying the size
            string[] teams = { "Aus", "Eng", "Ind" }; // Create an array of 3 elements, omitting the new keyword
            string[] car = new string[3]; // Create an array of 3 elements and add values later

            // Add values to the "car" array
            car[0] = "Toyota";
            car[1] = "Honda";
            car[2] = "Ford";

            // Print the contents of each array
            Console.WriteLine("car: " + string.Join(", ", car));
            Console.WriteLine("bike: " + string.Join(", ", bike));
            Console.WriteLine("color: " + string.Join(", ", color));
            Console.WriteLine("teams: " + string.Join(", ", teams));
            

            // Print the contents of the "car" array
            /* 
            Console.WriteLine(car[0]);
            Console.WriteLine(car[1]);
            Console.WriteLine(car[2]);
            */

            /*
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(car[i]);
            }
            */
            

            /*
            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }
            */

            /*
            foreach (string item in car)
            {
                Console.WriteLine(item);
            }
            */
            

            Console.ReadLine();
        }
    }
}
