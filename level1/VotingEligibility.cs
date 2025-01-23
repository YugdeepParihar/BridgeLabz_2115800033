using System;

class VotingEligibility
{
    static void Main(string[] args)
    {
        // Prompt user to enter their age
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        
        // Check voting eligibility
        if (age >= 18)
        {
            Console.WriteLine($"The person's age is {age} and can vote.");
        }
        else
        {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}