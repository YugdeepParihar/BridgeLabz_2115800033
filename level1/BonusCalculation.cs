using System;

class BonusCalculation
{
    static void Main()
    {
        Console.Write("Enter your salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());

        if (yearsOfService > 5)
        {
            double bonus = 0.05 * salary;
            Console.WriteLine($"Your bonus amount is: {bonus}");
        }
        else
        {
            Console.WriteLine("You are not eligible for a bonus.");
        }
    }
}