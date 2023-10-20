using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_in_struct
{
    struct Employee
    {
        public int id;

        public int Id
        {
            get { return id;}
            set { id = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp  = new Employee();

            emp.id = 1;
            Console.WriteLine("Employee ID: " + emp.id);

            Console.ReadLine();
        }
    }
}
