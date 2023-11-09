using System;

public class ExampleClass
{
    // Instance variable
    private int instanceVariable = 10;

    public void ExampleMethod()
    {
        // Local variable
        int localVariable = 5;

        Console.WriteLine("Instance Variable: " + instanceVariable);
        Console.WriteLine("Local Variable: " + localVariable);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ExampleClass obj = new ExampleClass();
        obj.ExampleMethod();

        Console.ReadLine();
    }
}

/*
The instance variable (instanceVariable) is accessible throughout the entire ExampleClass. 
The local variable (localVariable) is accessible only within the scope of the ExampleMethod method.
 */
