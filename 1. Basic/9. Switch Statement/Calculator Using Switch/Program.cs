using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0; // Initialize the variable to store the result.

            // Get the first number from the user.
            Console.WriteLine("Enter the first number:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            // Get the second number from the user.
            Console.WriteLine("Enter the second number:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            // Get the operator from the user.
            Console.WriteLine("Enter the operator (+, -, *, /):");
            char operation = Convert.ToChar(Console.ReadLine());

            // Switch on the operator symbol.
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    break;

                case '/':
                    if (secondNumber != 0) // Check for division by zero
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("Cannot divide by zero!");
                        return; // Exit the program if division by zero is attempted
                    }
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    return; // Exit the program if an invalid operator is used
            }

            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
        }
    }
}
