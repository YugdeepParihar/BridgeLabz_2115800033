using System;

// Class to check whether a given number is an Armstrong number
class ArmstrongNumberCheck
{
    static void Main(string[] args)
    {
        // Read the input number from the user
        int num = Convert.ToInt32(Console.ReadLine());

        // Store the original number in a temporary variable
        int temp = num;

        // Variable to store the sum of cubes of digits
        int sum = 0;

        // Loop to calculate the sum of the cubes of the digits
        while (temp != 0)
        {
            // Get the last digit of the number
            int rem = temp % 10;

            // Remove the last digit from the number
            temp /= 10;

            // Add the cube of the digit to the sum
            sum += (int)Math.Pow(rem, 3);
        }

        // Check if the sum of the cubes of digits equals the original number
        // If true, the number is an Armstrong number; otherwise, it's not
        Console.WriteLine(sum == num ? "Armstrong" : "Not Armstrong");
    }
}
