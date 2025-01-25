using System;

class DigitFrequency {
    static void Main() {
        Console.WriteLine("Enter a number:");
        long number = Convert.ToInt64(Console.ReadLine());

        int[] frequency = new int[10];

        while (number != 0) {
            int digit = (int)(number % 10);
            frequency[digit]++;
            number /= 10;
        }

        Console.WriteLine("Digit Frequencies:");
        for (int i = 0; i < 10; i++) {
            if (frequency[i] > 0) {
                Console.WriteLine($"Digit {i}: {frequency[i]} time(s)");
            }
        }
    }
}