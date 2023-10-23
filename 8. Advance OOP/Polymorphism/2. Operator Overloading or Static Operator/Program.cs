using System;
using System.Xml.Linq;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor that takes the X and Y coordinates of the point as parameters.
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    //  The overloaded "operator +()" method adds two Point objects together.
    public static Point operator +(Point p1, Point p2)
    {
        // Create a new Point object with the sum of the X and Y coordinates of the two operands.
        return new Point(p1.X + p2.X, p1.Y + p2.Y);
    }

    // Override the ToString method to print the coordinates.
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two Point objects.
        Point p1 = new Point(1, 2);
        Point p2 = new Point(3, 4);

        // Add the two points together using the overloaded "operator +()"
        Point p3 = p1 + p2;
        Console.WriteLine(p3); // (4, 6)
        Console.ReadLine();
    }
}

/*
 
##public static Point operator +(Point p1, Point p2)

The "operator +()" method is declared with the public access modifier, indicating that it can be accessed from outside the class.
It is static, which means it can be called without creating an instance of the Point class.
The method takes two Point objects, p1 and p2, as parameters.


##Return Value:  return new Point(p1.X + p2.X, p1.Y + p2.Y);
The "operator +()" method returns a new Point object with the calculated sum of the X and Y coordinates.


## public override string ToString()
    {
        return $"({X}, {Y})";
    }

The ToString() method is a virtual method in the Object class. 
It is used to convert an object to a string representation so that it can be displayed.
 */
