using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.Write("Enter a number to find its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}