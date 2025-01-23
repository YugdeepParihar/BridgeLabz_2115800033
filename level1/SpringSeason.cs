using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        // Prompt user to enter the month and day
        Console.Write("Enter the month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the day (1-31): ");
        int day = Convert.ToInt32(Console.ReadLine());
        
        // Check if the date falls in spring season
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season.");
        }
        else
        {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}
