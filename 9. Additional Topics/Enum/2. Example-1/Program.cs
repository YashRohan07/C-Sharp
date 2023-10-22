using System;
using System.Linq;

namespace ENUM
{
    class Program
    {
        enum Categories
        {
            Electronics = 10,
            Furniture = 3,
            Food = 5,
            Arts = 2
        }

        static void Main(string[] args)
        {
            string[] value = Enum.GetNames(typeof(Categories));   //This line assigns the array of enum names to the string array value.

            foreach (string s in value)
            {
                Console.WriteLine(s);
            }


            int[] n = (int[])Enum.GetValues(typeof(Categories));  //int[] n = (int[])Enum.GetValues(typeof(Categories));: This line assigns the array of enum values to the integer array n.
                                                                  //(int[])Enum.GetValues(typeof(Categories)): This line explicitly casts the array of enum values to an array of integers.
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }

            /*
             
            // Alternative method for getting enum names
            var enumNames = Enum.GetNames(typeof(Categories));
            foreach (var name in enumNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("==========================");

            // Alternative method for getting enum values
            var enumValues = Enum.GetValues(typeof(Categories));
            foreach (var value in enumValues)
            {
                Console.WriteLine((int)value);
            }

            */

            Console.ReadLine();
        }
    }
}
