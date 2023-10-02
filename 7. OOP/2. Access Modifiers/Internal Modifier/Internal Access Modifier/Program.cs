// Internal access modifier is used to restrict access to members (such as variables or methods) within the same assembly. 
// It works like the public access modifier
using System;

// Define a class named Employee in the same assembly.
internal class Employee
{
    internal string Name;
    internal void PrintName()
    {
        Console.WriteLine($"Employee Name: {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Employee class.
        Employee employee = new Employee();

        employee.Name = "John Doe";
        employee.PrintName();
        Console.ReadLine();
    }
}
