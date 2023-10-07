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
        }

        static void Main(string[] args)
        {
            // You need to provide an integer argument when creating an instance of Test.
            Test obj = new Test(5);

            Console.WriteLine("Value of num: " + obj.num);  //Value of num: 5
            Console.ReadLine();
        }
    }
}


