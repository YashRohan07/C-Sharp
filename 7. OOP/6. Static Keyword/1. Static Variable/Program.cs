using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Variable
{
    class Student
    {
        //Static variable
        public static string department = "CSE";

        class Program
        {
            static void Main(string[] args)
            {
                //we can access the static variable by using the class name
                Console.WriteLine("Department: " +Student.department);
                Console.ReadLine();
            }
        }
        
    }
}
