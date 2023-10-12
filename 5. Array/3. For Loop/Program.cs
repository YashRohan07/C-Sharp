using System;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] car = { "BMW", "AUDI", "HONDA" };

            for (int i = 0; i < car.Length; i++)
            {
                Console.WriteLine(car[i]);
            }

            Console.ReadLine();
        }
    }
}
