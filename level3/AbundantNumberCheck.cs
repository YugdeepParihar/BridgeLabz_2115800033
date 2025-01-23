using System;

// Class to check whether a given number is an Abundant Number
class AbundantNumberCheck
{
    static void Main(string[] args)
    {
        // Read the input number from the user
        int num = Convert.ToInt32(Console.ReadLine());

        // Initialize a variable to store the sum of divisors
        int sum = 0;

        // Loop through all possible divisors of the number up to num/2
        for (int i = 1; i <= num / 2; i++)
        {
            // Check if 'i' is a divisor of 'num'
            if (num % i == 0)
            {
                // Add the divisor to the sum
                sum += i;
            }
        }

        // Check if the sum of divisors is greater than the number
        // If true, the number is "Abundant", otherwise "Not Abundant"
        Console.WriteLine(sum > num ? "Abundant" : "Not Abundant");
    }
}
