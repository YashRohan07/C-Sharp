using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    //Defining struct
    struct Employee
    {
        public int id;
        public void getId(int id)
        {
            Console.WriteLine("Employee ID: " + id);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Declare emp variable of struct Employee
            Employee emp;

            //Access and set struct field
            emp.id = 1;

            //Access struct methods
            emp.getId(emp.id);

            Console.ReadLine();
        }
    }
}
