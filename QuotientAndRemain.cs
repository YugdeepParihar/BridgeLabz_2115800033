using System;

class QuotientAndRemain
{
    static void Main(string[] args)
    {
        // Taking user inputs for two numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculating quotient and remainder
        int quotient = number1 / number2;
        int remainder = number1 % number2;

        // Outputting the result
        Console.WriteLine($"\nThe Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}.");
    }
}
