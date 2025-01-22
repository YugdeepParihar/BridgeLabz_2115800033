using System;

class ChocolateDivision
{
    static void Main(string[] args)
    {
        // Taking user inputs for the number of chocolates and number of children
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculating the number of chocolates each child gets and the remaining chocolates
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Outputting the result
        Console.WriteLine($"\nThe number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}.");
    }
}
