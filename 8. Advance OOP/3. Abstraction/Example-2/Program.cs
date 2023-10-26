using System;

namespace Abstract_Class
{
    // Abstract class
    abstract class Shape
    {
        // Abstract method for calculating the area of a shape
        public abstract double area();
    }

    // Circle class inheriting from Shape
    class Circle : Shape
    {
        private double radius;

        // Constructor for the Circle class
        public Circle(double r)
        {
            radius = r;
        }

        // Implementation of the area method for a circle
        public override double area()
        {
            return (3.14 * radius * radius);
        }
    }

    // Square class inheriting from Shape
    class Square : Shape
    {
        private double side;

        // Constructor for the Square class
        public Square(double s)
        {
            side = s;
        }

        // Implementation of the area method for a square
        public override double area()
        {
            return (side * side);
        }
    }

    // Triangle class inheriting from Shape
    class Triangle : Shape
    {
        private double tbase;
        private double theight;

        // Constructor for the Triangle class
        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }

        // Implementation of the area method for a triangle
        public override double area()
        {
            return (0.5 * tbase * theight);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5.0);
            Console.WriteLine("Area of Circle    = {0}", c.area());

            Square s = new Square(2.5);
            Console.WriteLine("Area of Square    = {0}", s.area());

            Triangle t = new Triangle(2.0, 5.0);
            Console.WriteLine("Area of Triangle  = {0}", t.area());

            Console.ReadLine();
        }
    }
}
