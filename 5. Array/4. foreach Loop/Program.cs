using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] color = {"Black","White","Red"};
            
            //foreach(type variableName in arrayName)
            foreach(string i in color)
            {
                Console.WriteLine(i);
            }


            int[] num = { 1, 2, 3 };
            foreach (int j in num)
            {
                Console.WriteLine(j);
            }

            Console.ReadLine();

        }
    }
}
