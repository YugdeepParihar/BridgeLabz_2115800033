using System;

// Class to check if a number is a Harshad number (also known as a Niven number)
class HarshadNumberChecker
{
    static void Main(string[] args)
    {
        // Read an integer input from the user
        int num = Convert.ToInt32(Console.ReadLine()); // Input number to check
        int temp = num; // Temporary variable to hold the input number
        int sum = 0; // Variable to store the sum of digits

        // Calculate the sum of the digits of the number
        while (temp != 0)
        {
            int rem = temp % 10; // Extract the last digit
            temp /= 10; // Remove the last digit from the number
            sum += rem; // Add the digit to the sum
        }

        // Check if the number is divisible by the sum of its digits
        Console.WriteLine(num % sum == 0 ? "Harshad" : "Not Harshad");
    }
}
