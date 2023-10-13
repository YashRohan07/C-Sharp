/*
the string.Join method is used to concatenate the elements of the array into a single string,
separating each element with a space.
 */
using System;
class Program
{
    static void Main()
    {
        string[] words = { "Hello", "I", "am", "Yash", "Rohan"};
        string result = string.Join(" ", words); // Join the array elements with a space separator

        Console.WriteLine(result);
        Console.ReadLine();
    }
}
