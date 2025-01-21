using System;

class TernaryOperator
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int max = (a > b) ? a : b;

        Console.WriteLine("Max: " + max);

    }
}