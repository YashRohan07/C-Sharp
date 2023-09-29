/* Write a program to check whether a triangle can be formed by the given value for the angles. */
using System;

namespace Lab_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three angles of the triangle:");

            Console.Write("Angle 1: ");
            double angle1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle 2: ");
            double angle2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Angle 3: ");
            double angle3 = Convert.ToDouble(Console.ReadLine());

            
            bool Triangle = Possible_Triangle(angle1, angle2, angle3);

            if (Triangle)
            {
                Console.WriteLine("A triangle can be formed with these angles.");
            }
            else
            {
                Console.WriteLine("A triangle cannot be formed with these angles.");
            }

            Console.ReadLine();
        }

        static bool Possible_Triangle(double angle1, double angle2, double angle3)
        {
            // Check if the sum of angles is 180 degrees and all angles are greater than 0
            return angle1 + angle2 + angle3 == 180 && angle1 > 0 && angle2 > 0 && angle3 > 0;
        }
    }
}

