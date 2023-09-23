using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Statement_With_Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=1; i<=3; i++)
            {
                for(int j=1; j<=3; j++)
                {
                    if(i==2)
                    {
                        break;
                    }
                    Console.WriteLine("i = " + i + " j = " +j);
                }
            }
            Console.ReadLine();
        }
    }
}

/*
 
i = 1 j = 1
i = 1 j = 2
i = 1 j = 3
i = 3 j = 1
i = 3 j = 2
i = 3 j = 3
 
*/
