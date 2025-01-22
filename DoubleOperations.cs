using System;

class DoubleOperations
{
    static void Main(string[] args)
    {
        // Taking user inputs for a, b, and c
        Console.Write("Enter the value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Calculating the double operations
        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;

        // Outputting the results
        Console.WriteLine($"\nThe results of Double Operations are {result1}, {result2}, {result3}, and {result4}.");
    }
}
