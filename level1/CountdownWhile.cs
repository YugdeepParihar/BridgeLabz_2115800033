using System;

class CountdownWhile
{
    static void Main(string[] args)
    {
        // Prompt user for the countdown start value
        Console.Write("Enter the countdown starting value: ");
        double counter = Convert.ToDouble(Console.ReadLine());
        
        // Countdown using a while loop
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--; // Decrement the counter
        }
        Console.WriteLine( “Stopped!");
    }
}