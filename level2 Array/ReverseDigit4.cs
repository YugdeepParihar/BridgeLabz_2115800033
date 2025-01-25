using System;

class ReverseDigits {
    static void Main() {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine()); // Input number

        int digitCount = 0;
        int tempNumber = number;

        // Count the number of digits
        while (tempNumber > 0) {
            digitCount++;
            tempNumber /= 10;
        }

        int[] digits = new int[digitCount]; // Array to store digits
        int index = 0;

        // Extract digits from the number
        while (number > 0) {
            digits[index++] = number % 10;
            number /= 10;
        }

        // Display reversed number
        Console.Write("Reversed Number: ");
        for (int i = digitCount - 1; i >= 0; i--) {
            Console.Write(digits[i]);
        }
        Console.WriteLine();
    }
}
