using System;

class SumNaturalWhile
{
    static void Main(string[] args)
    {
        // Prompt user for a natural number
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        if (n > 0)
        {
            int sum = 0, i = 1;
            while (i <= n)
            {
                sum += i;
                i++;
            }
            
            int formulaSum = n * (n + 1) / 2; // Sum using the formula
            
            Console.WriteLine($"Sum using while loop: {sum}");
            Console.WriteLine($"Sum using formula: {formulaSum}");
            Console.WriteLine($"Are both results equal? {sum == formulaSum}");
        }
        else
        {
            Console.WriteLine($"{n} is not a natural number.");
        }
    }
}