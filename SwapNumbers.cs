using System;

class SwapNumbers
{
    static void Main(string[] args)
    {
        // Taking user input for two numbers
        Console.Write("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Swapping the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Outputting the swapped result
        Console.WriteLine($"\nThe swapped numbers are {number1} and {number2}.");
    }
}
