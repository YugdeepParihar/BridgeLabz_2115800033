using System;

class Program
{
    static void Main()
    {
        // Declare variables
        int number;
        int maxDigit = 10; // Initial size of the array
        int index = 0; // Index to track the number of digits stored
        int[] digits = new int[maxDigit]; // Array to store the digits
        int largest = 0, secondLargest = 0;

        // Take user input for the number
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Loop to extract digits and store them in the digits array
        while (number != 0)
        {
            // Check if the index equals maxDigit
            if (index == maxDigit)
            {
                // Increase the size of the array by 10
                maxDigit += 10;
                
                // Create a temporary array with the new size
                int[] temp = new int[maxDigit];
                
                // Copy the elements from the current digits array to the temp array
                Array.Copy(digits, temp, digits.Length);
                
                // Assign the temp array back to digits
                digits = temp;
            }
            
            // Store the last digit in the array
            digits[index] = number % 10;
            
            // Remove the last digit from the number
            number /= 10;
            
            // Increment the index
            index++;
        }

        // Find the largest and second-largest digits in the array
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        // Display the largest and second-largest digits
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}