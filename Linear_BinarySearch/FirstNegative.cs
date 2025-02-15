using System;

class Program
{
    static int FindFirstNegative(int[] arr)
    {
        // Iterate through the array to find the first negative number
        for (int i = 0; i < arr.Length; i++)
        {
            // Check if the current element is negative
            if (arr[i] < 0)
            {
                return arr[i]; // Return the first negative number found
            }
        }
        return -1; // Return -1 if no negative number is found
    }

    static void Main()
    {
        int[] arr = { 3, 5, -2, 8, -7, 10 };
        Console.WriteLine("First negative number: " + FindFirstNegative(arr));
    }
}