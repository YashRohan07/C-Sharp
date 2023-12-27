using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John", "30");

            PermanentEmployee permanentEmployee = new PermanentEmployee("Smith", "35", 50000);

            ContractEmployee contractEmployee = new ContractEmployee("Johnson", "28", 30000);

            Console.WriteLine("Employee: {0}, Age: {1}", employee.Name, employee.Age);
            Console.WriteLine("Permanent Employee: {0}, Age: {1}, Salary: {2}", permanentEmployee.Name, permanentEmployee.Age, permanentEmployee.Salary);
            Console.WriteLine("Contract Employee: {0}, Age: {1}, Salary: {2}", contractEmployee.Name, contractEmployee.Age, contractEmployee.Salary);

            Console.ReadLine();  
        }
    }
}
