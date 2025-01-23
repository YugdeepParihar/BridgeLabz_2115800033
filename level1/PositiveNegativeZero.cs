using System;

class PositiveNegativeZero
{
    static void Main(string[] args)
    {
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Check the number type and display result
        if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}