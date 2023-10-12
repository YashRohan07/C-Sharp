using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_an_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sort a string
            string[] color = {"Black","Red","White"};
            Array.Sort(color);

            foreach(string i in color)
            {
                Console.WriteLine(i);  //Output: Black Red White
            }

            int[] num = { 5, 7, 3, 8, };
            Array.Sort(num);

            foreach(int j in num)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();
        }
    }
}
