using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Get
{
    class Person
    {
        private string name; // Field to store the person's name

        public string Name // Property to access and set the person's name
        {
            get { return name; } // Getter returns the value of the 'name' field
            set { name = value; } // Setter sets the 'name' field to the provided value
        }

        class Program
        {
            static void Main(string[] args)
            {
                Person obj = new Person(); 

                // Set the person's name using the property
                obj.Name = "Rohan";

                // Get and print the person's name using the property
                Console.WriteLine(obj.Name);

                Console.ReadLine(); 
            }
        }
    }
}
