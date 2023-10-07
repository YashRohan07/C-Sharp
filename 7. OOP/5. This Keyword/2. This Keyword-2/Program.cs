using System;

class MyClass
{
    private int myValue;

    public MyClass(int value)
    {
        // Use 'this' to distinguish between the parameter and instance variable.
        this.myValue = value;
    }

    public void DisplayValue()
    {
        Console.WriteLine("Instance variable myValue: " + this.myValue);  //5
    }
}

class Program
{
    static void Main()
    {
        MyClass obj = new MyClass(5);
        obj.DisplayValue();
        Console.ReadLine();
    }
}
