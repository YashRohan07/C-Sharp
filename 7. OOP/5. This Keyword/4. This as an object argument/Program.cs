using System;

namespace this_as_an_object_argument
{
    class Test
    {
        int num1;
        int num2;

        Test()
        {
            num1 = 22;
            num2 = 33;
        }

        // Method to pass the current instance as an argument
        void passParameter(Test obj)
        {
            Console.WriteLine("num1: " + obj.num1); 
            Console.WriteLine("num2: " + obj.num2); 
        }

        void display()
        {
            passParameter(this); // Pass the current instance (i.e., 'this') to passParameter method
        }

        static void Main(string[] args)
        {
            Test obj = new Test(); 
            obj.display(); 
            Console.ReadLine(); 
        }
    }
}
