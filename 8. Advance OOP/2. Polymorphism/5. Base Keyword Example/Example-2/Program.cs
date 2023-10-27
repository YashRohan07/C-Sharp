using System;

// Base class Person
public class Person
{
    protected string id = "444";
    protected string name = "Yash Rohan";
    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", name); 
        Console.WriteLine("ID: {0}", id); 
    }
}

// Derived class Employee from Person
class Employee : Person
{
    public string id = "ABC567EFG"; // Shadowing the id field

    // Override the GetInfo method from the base class
    public override void GetInfo()
    {
        // Call the base class GetInfo method
        base.GetInfo();

        Console.WriteLine("Employee ID: {0}", base.id); // Print base class's id  (Employee ID: 444)
        Console.WriteLine("Employee ID: {0}", id); // Print derived class's id    (Employee ID: ABC567EFG)
        Console.WriteLine("Employee ID: {0}", this.id); // Print current instance's id  (Employee ID: ABC567EFG)
    }
}

class Program
{
    static void Main()
    {
        Employee E = new Employee(); 
        E.GetInfo(); // Call the GetInfo method of Employee

        Console.ReadLine();
    }
}

/*
 
Output:
Name: Yash Rohan
ID: 444
Employee ID: 444
Employee ID: ABC567EFG
Employee ID: ABC567EFG

 */
