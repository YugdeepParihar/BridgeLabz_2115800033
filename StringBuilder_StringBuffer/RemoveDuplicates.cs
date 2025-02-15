using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // Prompt the user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Remove duplicates and display the result
        string result = RemoveDuplicates(input);
        Console.WriteLine("String after removing duplicates: " + result);
    }

    static string RemoveDuplicates(string input)
    {
        // Use a HashSet to track seen characters
        HashSet<char> seen = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        // Iterate through each character in the input string
        foreach (char c in input)
        {
            // If the character hasn't been seen before, add it to the result
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result.Append(c);
            }
        }

        // Convert the StringBuilder to a string and return it
        return result.ToString();
    }
}