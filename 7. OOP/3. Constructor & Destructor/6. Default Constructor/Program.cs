using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Default_Constructor
{
    class Program
    {
        int a;
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Default value of a: " +obj.a);  //Output: 0
            Console.ReadLine();
        }
    }
}
