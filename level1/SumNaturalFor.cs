using System;

class SumNaturalFor
{
    static void Main(string[] args)
    {
        // Prompt user for a natural number
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n > 0)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            
            int formulaSum = n * (n + 1) / 2; // Sum using the formula
            
            Console.WriteLine($"Sum using for loop: {sum}");
            Console.WriteLine($"Sum using formula: {formulaSum}");
            Console.WriteLine($"Are both results equal? {sum == formulaSum}");
        }
        else
        {
            Console.WriteLine($"{n} is not a natural number.");
        }
    }
}