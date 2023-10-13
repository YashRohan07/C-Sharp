using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] number = { { 1, 2, 3 }, { 4, 5, 6 } };

            foreach(int i in number)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
