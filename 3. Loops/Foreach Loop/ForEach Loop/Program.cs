﻿using System;

namespace ForEach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Define an array of car brands
            string[] cars = { "BMW", "AUDI", "FORD", "MERCEDES" };
            
            //foreach(type variableName in arrayName)
            foreach (string car in cars)
            {
                // Print each car brand to the console
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}
