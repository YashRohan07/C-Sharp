using System;

namespace This_Keyword
{
    class Test
    {
        int num; //Instance variable

        // Constructor with a parameter 'num' to initialize the instance variable.
        Test(int num)
        {
            this.num = num; // 'this' refers to the current instance of the class.
            Console.WriteLine("Object of this: " + this);
        }

        static void Main(string[] args)
        {
            // You need to provide an integer argument when creating an instance of Test.
            Test obj = new Test(42);

            Console.WriteLine("Object of obj: " + obj);
            Console.ReadLine();
        }
    }
}

/*
 
Output:
Object of this: This_Keyword.Test
Object of obj: This_Keyword.Test

 */
