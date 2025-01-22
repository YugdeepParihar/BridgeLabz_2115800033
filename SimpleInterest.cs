using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        // Taking user inputs for principal, rate, and time
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time period (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        // Calculating the simple interest
        double simpleInterest = (principal * rate * time) / 100;

        // Outputting the result
        Console.WriteLine($"\nThe simple interest on a principal of {principal} at a rate of {rate}% for {time} years is {simpleInterest}.");
    }
}
