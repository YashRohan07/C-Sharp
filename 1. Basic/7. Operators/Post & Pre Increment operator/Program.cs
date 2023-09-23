using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post___Pre_Increment_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            Console.WriteLine((num++));  // 10
            Console.WriteLine((num));    // 11

            Console.WriteLine((++num));  // 12
            Console.WriteLine((num));    // 12

            Console.ReadLine();
        }
    }
}
