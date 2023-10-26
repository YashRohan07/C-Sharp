using System;

public class Circle
{
    public readonly double Pi = 3.14;
    public readonly double Radius;

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Pi * Radius * Radius;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle obj = new Circle(2.0);
        Console.WriteLine("Area of the circle with radius " + obj.Radius + " is " + obj.CalculateArea());

        //obj.Pi = 3.14159; // This will give a compilation error since Pi is readonly

        Console.ReadLine();
    }
}

/*
The Pi is declared as readonly, and it cannot be modified after its initialization within the class.
This ensures that the value of Pi remains constant throughout the life of the object, and 
any attempt to modify it after the object is constructed will result in a compilation error.
 */
