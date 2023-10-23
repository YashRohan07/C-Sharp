using System;

namespace Static_Operator
{
    class Point
    {
        private int x;
        private int y;

        // Constructor to initialize the coordinates
        public Point(int x1 = 0, int y1 = 0)
        {
            x = x1;
            y = y1;
        }

        // Overloading the + operator to add two Point objects
        public static Point operator +(Point p1, Point p2)
        {
            // Creating a new Point object and setting its coordinates
            Point p3 = new Point();
            p3.x = p1.x + p2.x;
            p3.y = p1.y + p2.y;
            return p3;
        }

        // Method to display the coordinates of a Point
        public void display()
        {
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
        }
    }
    class Example
    {
        static void Main(string[] args)
        {
            // Creating three Point objects
            Point p1 = new Point(5, 7);
            Point p2 = new Point(9, 2);
            Point p3 = new Point();

            // Operator Overloading
            p3 = p1 + p2;

            // Displaying the coordinates of the points
            Console.WriteLine("Point p1 is:");
            p1.display();
            Console.WriteLine("Point p2 is:");
            p2.display();
            Console.WriteLine("Point p3 is:");
            p3.display();

            Console.ReadLine();
        }
    }
}
