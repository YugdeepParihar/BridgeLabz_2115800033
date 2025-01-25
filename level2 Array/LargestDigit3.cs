using System;

class LargestDigits {
    static void Main() {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = new int[10];
        int index = 0;

        while (number > 0) {
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = -1, secondLargest = -1;
        for (int i = 0; i < index; i++) {
            if (digits[i] > largest) {
                secondLargest = largest;
                largest = digits[i];
            } else if (digits[i] > secondLargest && digits[i] != largest) {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"Largest Digit: {largest}");
        Console.WriteLine($"Second Largest Digit: {secondLargest}");
    }
}
