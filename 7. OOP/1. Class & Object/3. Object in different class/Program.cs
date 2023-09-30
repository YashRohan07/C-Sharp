using System;

namespace Object_in_different_class
{
    class Employee
    {
        public string name;

        public void work(string work)
        {
            Console.WriteLine("Work: " + work);
        }
    }

    class EmployeeDrive
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Employee 1");

            // Set the Employee name
            e1.name = "Yash";
            Console.WriteLine("Name: " + e1.name);

            // Call the method of Employee class
            e1.work("Coding");

            Console.ReadLine();
        }
    }
}
