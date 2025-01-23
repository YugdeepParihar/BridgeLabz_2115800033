using System;

class LargestOfThree
{
    static void Main(string[] args)
    {
        // Prompt user to enter three numbers
        Console.Write("Enter first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        
        // Check which number is the largest
        bool isFirstLargest = num1 > num2 && num1 > num3;
        bool isSecondLargest = num2 > num1 && num2 > num3;
        bool isThirdLargest = num3 > num1 && num3 > num2;
        
        // Display the results
        Console.WriteLine($"Is the first number the largest? {isFirstLargest}");
        Console.WriteLine($"Is the second number the largest? {isSecondLargest}");
        Console.WriteLine($"Is the third number the largest? {isThirdLargest}");
    }
}