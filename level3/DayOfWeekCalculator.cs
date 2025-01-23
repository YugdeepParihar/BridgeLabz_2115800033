using System;

// Class to calculate the day of the week based on a given date
class DayOfWeekCalculator
{
    static void Main(string[] args)
    {
        // Read month, day, and year inputs from the user
        int m = Convert.ToInt32(Console.ReadLine()); // Month (1-12)
        int d = Convert.ToInt32(Console.ReadLine()); // Day (1-31)
        int y = Convert.ToInt32(Console.ReadLine()); // Year (e.g., 2025)

        // Adjust the year and month for the Zeller's Congruence formula
        int y0 = y - (14 - m) / 12; // Adjust year if the month is January or February
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400; // Century-based offset
        int m0 = m + 12 * ((14 - m) / 12) - 2; // Adjust month to align with formula
        int d0 = (d + x + 31 * m0 / 12) % 7; // Calculate the day of the week (0-6)

        // Determine the day of the week using a switch statement
        switch (d0)
        {
            case 0:
                Console.WriteLine("Sunday");
                break;
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
        }
    }
}
