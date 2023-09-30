using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_WIth_Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5};

            foreach(int number in num)
            {
                if(number == 3)
                {
                    break;
                }

                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}

//Output: 1 2

