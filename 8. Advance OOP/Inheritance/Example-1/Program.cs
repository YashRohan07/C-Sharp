using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Shape
    {
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
    }

    class Triangle : Shape
    {
        public string Style;
        public double Area()
        {
            return Width * Height / 2;
        }
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();

            t1.Width = 10.0;
            t1.Height = 10.0;
            t1.Style = "isosceles";

            t2.Width = 12.0;
            t2.Height = 16.0;
            t2.Style = "right";

            Console.WriteLine("Details for Triangle 1 : ");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("Details for Triangle 2 : ");
            t2.ShowStyle();
            t2.ShowDim();
            Console.WriteLine("Area is " + t2.Area());

            Console.ReadLine();
        }
    }

}

/*
 Output:

Details for Triangle 1 :
Triangle is isosceles
Width and height are 10 and 10
Area is 50

Details for Triangle 2 :
Triangle is right
Width and height are 12 and 16
Area is 96

 */
