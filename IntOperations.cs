using System;

class IntOperations
{
    static void Main(string[] args)
    {
        // Taking user inputs for a, b, and c
        Console.Write("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Calculating the integer operations
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        // Outputting the results
        Console.WriteLine($"\nThe results of Int Operations are {result1}, {result2}, {result3}, and {result4}.");
    }
}
