using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Ask the user for the number of strings
        Console.Write("Enter the number of strings: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Initialize an array to store the strings
        string[] strings = new string[n];

        // Take input for each string
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter string {i + 1}: ");
            strings[i] = Console.ReadLine();
        }

        // Concatenate the strings using StringBuilder
        string result = ConcatenateStrings(strings);

        // Display the result
        Console.WriteLine("Concatenated string: " + result);
    }

    static string ConcatenateStrings(string[] strings)
    {
        // Create a StringBuilder object
        StringBuilder sb = new StringBuilder();

        // Iterate through each string in the array and append it to the StringBuilder
        foreach (string str in strings)
        {
            sb.Append(str);
        }

        // Convert the StringBuilder to a string and return it
        return sb.ToString();
    }
}