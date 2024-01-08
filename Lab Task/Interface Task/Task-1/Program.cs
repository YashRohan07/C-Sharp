using System;

public interface IBasicCalculator
{
    int Sum(int x, int y);
    int Sub(int x, int y);
    int Multiplication(int x, int y);
    int Division(int x, int y);
}

public interface IScientificCalculator
{
    int XtoY(int x, int y);
    int Factorial(int x);
    double Abs(double x);
    double Sqrt(double x);
}

public class BasicCalculator : IBasicCalculator
{
    public int Sum(int x, int y)
    {
        return x + y;
    }

    public int Sub(int x, int y)
    {
        return x - y;
    }

    public int Multiplication(int x, int y)
    {
        return x * y;
    }

    public int Division(int x, int y)
    {
        return x / y;
    }
}

public class ScientificCalculator : IScientificCalculator
{
    public int XtoY(int x, int y)
    {
        return (int)Math.Pow(x, y);
    }

    public int Factorial(int x)
    {
        if (x == 0)
        {
            return 1;
        }
        else
        {
            return x * Factorial(x - 1);
        }
    }

    public double Abs(double x)
    {
        return Math.Abs(x);
    }

    public double Sqrt(double x)
    {
        return Math.Sqrt(x);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        IBasicCalculator basicCalculator = new BasicCalculator();
        Console.WriteLine("Sum: " + basicCalculator.Sum(10, 20));
        Console.WriteLine("Subtraction: " + basicCalculator.Sub(10, 20));
        Console.WriteLine("Multiplication: " + basicCalculator.Multiplication(10, 20));
        Console.WriteLine("Division: " + basicCalculator.Division(10, 20));

        IScientificCalculator scientificCalculator = new ScientificCalculator();
        Console.WriteLine("10 to the power of 20: " + scientificCalculator.XtoY(10, 20));
        Console.WriteLine("Factorial of 5: " + scientificCalculator.Factorial(5));
        Console.WriteLine("Absolute value of -5.5: " + scientificCalculator.Abs(-5.5));
        Console.WriteLine("Square root of 16: " + scientificCalculator.Sqrt(16));

        Console.ReadLine();
    }
}
