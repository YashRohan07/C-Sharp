using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables for the first number, second number, and result.
            double firstNumber, secondNumber, result = 0;

            // Get the first number from the user.
            Console.WriteLine("Enter the first number:");
            firstNumber = Convert.ToDouble(Console.ReadLine());

            // Get the second number from the user.
            Console.WriteLine("Enter the second number:");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            // Get the operator from the user.
            char operatorSymbol;
            Console.WriteLine("Enter the operator (+, -, *, /):");
            operatorSymbol = (char)Console.Read();

            // Switch on the operator symbol.
            switch (operatorSymbol)
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
                    result = firstNumber / secondNumber;
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;

                
            }

            // Display the result.
            Console.WriteLine("The result is: " + result);

            // Keep the console window open so that the user can see the result.
            Console.ReadLine();
        }
    }
}
