using System;

public class Calculator
{
    public static void Main()
    {
        Console.WriteLine("=== Simple Calculator ===\n");

        double num1 = 15;
        double num2 = 7;

        Console.WriteLine($"Number 1: {num1}");
        Console.WriteLine($"Number 2: {num2}\n");

        Console.WriteLine("--- Results ---");
        Console.WriteLine($"Addition: {num1} + {num2} = {Add(num1, num2)}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {Subtract(num1, num2)}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {Multiply(num1, num2)}");
        Console.WriteLine($"Division: {num1} / {num2} = {Divide(num1, num2):F2}");
        Console.WriteLine($"Modulus: {num1} % {num2} = {Modulus(num1, num2)}");
        Console.WriteLine($"Power: {num1} ^ {num2} = {Power(num1, num2):F0}");

        Console.WriteLine("\n--- Additional Calculations ---");
        Console.WriteLine($"Square of {num1}: {Square(num1)}");
        Console.WriteLine($"Square root of {num1}: {SquareRoot(num1):F2}");
        Console.WriteLine($"Absolute value of -{num2}: {Absolute(-num2)}");
    }

    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) => b != 0 ? a / b : 0;
    public static double Modulus(double a, double b) => a % b;
    public static double Power(double a, double b) => Math.Pow(a, b);
    public static double Square(double a) => a * a;
    public static double SquareRoot(double a) => Math.Sqrt(a);
    public static double Absolute(double a) => Math.Abs(a);
}
