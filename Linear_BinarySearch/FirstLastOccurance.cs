using System;

class Program
{
    static int FindOccurrence(int[] arr, int target, bool first)
    {
        int left = 0, right = arr.Length - 1, result = -1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
            {
                result = mid; // Store the index
                if (first) right = mid - 1; // Search left half
                else left = mid + 1; // Search right half
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static void Main()
    {
        int[] arr = { 1, 2, 2, 2, 3, 4, 5 };
        Console.WriteLine("First occurrence: " + FindOccurrence(arr, 2, true));
        Console.WriteLine("Last occurrence: " + FindOccurrence(arr, 2, false));
    }
}
