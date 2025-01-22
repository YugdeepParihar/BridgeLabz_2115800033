using System;

class TotalIncome
{
    static void Main(string[] args)
    {
        // Taking user input for salary and bonus
        Console.Write("Enter the salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the bonus: ");
        double bonus = Convert.ToDouble(Console.ReadLine());

        // Calculating total income
        double totalIncome = salary + bonus;

        // Outputting the result
        Console.WriteLine($"\nThe salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}.");
    }
}
