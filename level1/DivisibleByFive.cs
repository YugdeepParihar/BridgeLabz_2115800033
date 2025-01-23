using System;

class DivisibleByFive
{
    static void Main(string[] args)
    {
        // Prompt user to enter a number
        Console.Write("Enter a number: ");
        
        // Read and convert user input to an integer
        int number = Convert.ToInt32(Console.ReadLine());
        
        // Check if the number is divisible by 5 and display the result
        Console.WriteLine($"Is the number {number} divisible by 5? {number % 5 == 0}");
    }
}

