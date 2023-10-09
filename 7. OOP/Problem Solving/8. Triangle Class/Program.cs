using System;

namespace Triangle_Class
{
    class Triangle
    {
        private int x, y, z;

        //Constructor
        public Triangle(int side1, int side2, int side3)
        {
            x = side1;
            y = side2;
            z = side3;

        }
        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Triangle is Equilateral");
            }
            else if (x == y || y == z || z == x)
            {
                Console.WriteLine("Triangle is Isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is Scalene");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of side 1:");
            int side1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side 2:");
            int side2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side 3:");
            int side3 = int.Parse(Console.ReadLine());

            Triangle t = new Triangle(side1, side2, side3);

            t.TestTriangle();
            Console.ReadLine();
        }

    }
}
