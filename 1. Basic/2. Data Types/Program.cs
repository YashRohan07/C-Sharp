using System;

namespace Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            long x = 5555555L;
            double b = 5.5D;
            float c = 6.5F;
            char d = 'r';
            string e = "Yash Rohan";
            bool isGreat = true;


            Console.WriteLine(a);
            Console.WriteLine(x);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(isGreat);

            Console.ReadLine();

        }
    }
}

/*
double b = 5.5D;
Here, b is a variable of type double. The value assigned to it is 5.5. The 'D' suffix explicitly indicates that the value is of type double. 
Although not necessary, it can be helpful for code clarity.

float c = 6.5F;
Here, c is a variable of type float. The value assigned to it is 6.5. The 'F' suffix explicitly denotes that the value is of type float.
Using 'F' is optional, but it helps in explicitly defining the type of the variable.

*/
