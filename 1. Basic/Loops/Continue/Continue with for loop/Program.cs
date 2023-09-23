using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Continue_with_for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=5; i++)
            {
                if(i==3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

/*
Output:
1
2
4
5
*/
