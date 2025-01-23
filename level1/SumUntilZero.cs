using System;

class SumUntilZero
{
    static void Main(string[] args)
    {
        double total = 0.0; // Initialize the sum variable
        
        while (true)
        {
            // Prompt user for input
            Console.Write("Enter a number (0 to stop): ");
            double input = Convert.ToDouble(Console.ReadLine());
            
            if (input == 0) // Break the loop if input is 0
            {
                break;
            }
            total += input; // Add input to the total
        }
        
        Console.WriteLine($"The total sum is: {total}");
    }
}