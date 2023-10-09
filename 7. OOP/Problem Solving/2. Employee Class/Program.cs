using System;

namespace Class_Object_extended
{
    class Employee
    {
        private int Id;
        private string Name;
        private float Salary;

        public Employee(int id, string name, float salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public void Display()
        {
            Console.WriteLine($"Employee ID: {Id}, Name: {Name}, Salary: {Salary:C}");
        }

        static void Main(string[] args)
        {
            // Create Employee objects with constructors
            Employee e1 = new Employee(1, "M", 80);
            Employee e2 = new Employee(2, "N", 70);
            Employee e3 = new Employee(3, "O", 80);

            e1.Display();
            e2.Display();
            e3.Display();

            Console.ReadLine();
        }
    }
}
