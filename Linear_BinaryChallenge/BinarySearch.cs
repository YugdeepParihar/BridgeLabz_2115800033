using System;

class BinarySearchProgram
{
    // Function to perform Binary Search on a sorted array
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid; // Target found at index mid
            else if (arr[mid] < target)
                left = mid + 1; // Search in the right half
            else
                right = mid - 1; // Search in the left half
        }
        return -1; // Target not found
    }

    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

       
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

       
        Array.Sort(arr);

        
        Console.Write("Enter the target value: ");
        int target = int.Parse(Console.ReadLine());

       
        int index = BinarySearch(arr, target);

        if (index != -1)
            Console.WriteLine("Target (" + target + ") found at index: " + index);
        else
            Console.WriteLine("Target (" + target + ") not found.");
    }
}
