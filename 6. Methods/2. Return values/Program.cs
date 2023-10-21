using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_values
{
    internal class Program
    {
        // Static method returning an integer from input
        static int Method1(int x)
        {
            return 5 + x;
        }

        // Static method returning the input string
        static string Method2(string name)
        {
            return name;
        }

        // Static method returning the sum of 5 and 5
        static int addNumber()
        {
            int sum = 5 + 5;
            return sum;
        }

        // Static method returning the result of subtracting
        static int deleteNumber(int x, int y)
        {
            return x - y;
        }

        // Non-static method that adds two integers
        public int add(int a, int b)
        {
            int addition = a + b;
            return addition;
        }

        static void Main(string[] args)
        {
            // Calling Method1, a static method
            Console.WriteLine(Method1(2));  //7

            // Calling Method2, a static method
            Console.WriteLine(Method2("John"));

            // Storing and printing the result of addNumber, a static method
            int sum = addNumber();
            Console.WriteLine(sum);

            // Storing and printing the result of deleteNumber, a static method
            int sub = deleteNumber(5, 2);
            Console.WriteLine(sub);


            Program obj = new Program();

            // Calling the non-static add method through the object and storing the result
            int addition = obj.add(2, 2);

            // Printing the result of the non-static method call
            Console.WriteLine(addition);

            Console.ReadLine();
        }
    }
}
