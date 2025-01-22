using System;

class CelsiusToFahrenheit
{
    static void Main(string[] args)
    {
        // Taking user input for temperature in Celsius
        Console.Write("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Converting Celsius to Fahrenheit
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Outputting the result
        Console.WriteLine($"\nThe {celsius} Celsius is {fahrenheit} Fahrenheit.");
    }
}
