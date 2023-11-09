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


/*
using System;

class Program
{
    static void Main()
    {
        // Integer data types
        byte a = 255; // 8-bit unsigned integer
        sbyte b = -128; // 8-bit signed integer
        short c = 32767; // 16-bit signed integer
        ushort d = 65535; // 16-bit unsigned integer
        int e = 2147483647; // 32-bit signed integer
        uint f = 4294967295; // 32-bit unsigned integer
        long g = 9223372036854775807; // 64-bit signed integer
        ulong h = 18446744073709551615; // 64-bit unsigned integer

        // Floating-point data types
        float i = 3.402823E+38F; // 32-bit single-precision floating point
        double j = 1.7976931348623157E+308D; // 64-bit double-precision floating point
        decimal k = 79228162514264337593543950335M; // 128-bit decimal type

        // Character and Boolean data types
        char l = 'A'; // 16-bit Unicode character
        bool m = true; // Boolean value true or false

        // String data type
        string n = "Hello, World!"; // Represents a sequence of characters
        
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);
        Console.WriteLine(l);
        Console.WriteLine(m);
        Console.WriteLine(n);

        Console.ReadLine(); 
    }
}

*/
