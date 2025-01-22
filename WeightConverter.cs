using System;

class WeightConversion
{
    static void Main(string[] args)
    {
        // Taking user input for weight in pounds
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Converting pounds to kilograms (1 pound = 2.2 kg)
        double weightInKilograms = weightInPounds * 2.2;

        // Outputting the result
        Console.WriteLine($"\nThe weight of the person is {weightInPounds} pounds and {weightInKilograms} kilograms.");
    }
}
