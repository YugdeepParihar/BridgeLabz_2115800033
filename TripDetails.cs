using System;

class TripDetails
{
    static void Main(string[] args)
    {
        // Taking user input for trip details
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter the from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter the via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter the to city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter the distance from 'from' to 'via' city in miles: ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance from 'via' to 'to' city in miles: ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());

        // Calculating the total distance and average speed
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        // Outputting the trip details
        Console.WriteLine($"\nThe results of the trip are: {name}, {fromCity} to {viaCity} to {toCity}, Total Distance: {totalDistance} miles, Average Speed: {averageSpeed} miles/hour.");
    }
}
