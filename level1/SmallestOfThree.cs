using System;

class SmallestOfThree
{
    static void Main(string[] args)
    {
        // Prompt the user to enter three numbers
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        // Check if the first number is the smallest
        bool isSmallest = num1 < num2 && num1 < num3;
        
        // Output the result
        Console.WriteLine($"Is the first number the smallest? {isSmallest}");
    }
}