using System;

class OddEvenNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 1)
        {
            Console.WriteLine("Please enter a natural number.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is an even number");
                }
                else
                {
                    Console.WriteLine($"{i} is an odd number");
                }
            }
        }
    }
}