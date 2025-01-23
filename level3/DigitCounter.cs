using System;

// Class to count the number of digits in a given number
class DigitCounter
{
    static void Main(string[] args)
    {
        // Read the input number from the user
        int num = Convert.ToInt32(Console.ReadLine());

        // Variable to store the count of digits
        int count = 0;

        // Loop to count the digits in the number
        while (num != 0)
        {
            // Remove the last digit of the number
            num /= 10;

            // Increment the digit count
            count++;
        }

        // Output the total number of digits
        Console.WriteLine(count);
    }
}
