using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_static_members_within_the_class
{
    class Program
    {
        static int age = 22;  //Static variable
        public static void display()
        {
            Console.WriteLine("Static method");
        }
        static void Main(string[] args)
        {
            /* If we are accessing the static variable and static methods inside the same class,
             we can directly access them without using the class name. */
            Console.WriteLine(age);
            display();

            Console.ReadLine();
        }
    }
}
