using System;

class FahrenheitToCelsius
{
    static void Main(string[] args)
    {
        // Taking user input for temperature in Fahrenheit
        Console.Write("Enter the temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Converting Fahrenheit to Celsius
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Outputting the result
        Console.WriteLine($"\nThe {fahrenheit} Fahrenheit is {celsius} Celsius.");
    }
}
