using System;

// Abstract class representing an Employee
abstract class Employee //abstract class
{
    public abstract int GetSalary(); //abstract method
}

// Developer class inheriting from Employee
class Developer : Employee
{
    private int salary;

    // Constructor for the Developer class
    public Developer(int s)
    {
        salary = s;
    }

    // Implementation of the abstract method GetSalary for Developer
    public override int GetSalary()
    {
        return salary;
    }
}

// Driver class inheriting from Employee
class Driver : Employee
{
    private int salary;

    // Constructor for the Driver class
    public Driver(int s)
    {
        salary = s;
    }

    // Implementation of the abstract method GetSalary for Driver
    public override int GetSalary()
    {
        return salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Developer and Driver classes
        Developer d1 = new Developer(5000);
        Driver d2 = new Driver(3000);

        // Getting salaries of Developer and Driver
        int a = d1.GetSalary();
        int b = d2.GetSalary();

        Console.WriteLine("Salary of developer : {0}", a);
        Console.WriteLine("Salary of driver : {0}", b);

        Console.ReadLine();
    }
}
