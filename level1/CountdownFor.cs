using System;
class CountdownFor
{
    static void Main(string[] args)
    {
        // Prompt user for the countdown start value
        Console.Write("Enter the countdown starting value: ");
        int start = Convert.ToInt32(Console.ReadLine());
        
        // Countdown using a for loop
        for (int i = start; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Stopped");
    }
}