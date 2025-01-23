using System;

class FactorialWhile
{
    static void Main(string[] args)
    {
        // Prompt user for a number
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number >= 0)
        {
            long factorial = 1;
            int i = 1;
            
            while (i <= number)
            {
                factorial *= i;
                i++;
            }
            
            Console.WriteLine($"The factorial of {number} is {factorial}");
        }
        else
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
    }
}