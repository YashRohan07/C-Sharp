using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    class Test
    {
        public void display1()
        {
            Console.WriteLine("Non static method");
        }

        public static void display2()
        {
            Console.WriteLine("Static method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();

            obj.display1(); //Calling the non static method 
            Test.display2(); //Calling the static method

            Console.ReadLine();
        }
    }
}
