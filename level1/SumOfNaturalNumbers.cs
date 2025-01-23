using System;

class SumOfNaturalNumbers
{
    static void Main(string[] args)
    {
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Check if the number is a natural number
        if (number > 0)
        {
            // Calculate the sum using the formula
            int sum = number * (number + 1) / 2;
            
            // Display the result
            Console.WriteLine($"The sum of {number} natural numbers is {sum}");
        }
        else
        {
            // Inform the user if the number is not natural
            Console.WriteLine($"The number {number} is not a natural number.");
        }
    }
}