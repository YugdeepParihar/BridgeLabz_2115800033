using System;

class Program
{
    static int FindRotationPoint(int[] arr)
    {
        int left = 0, right = arr.Length - 1;
        
        // If the array is not rotated
        if (arr[left] <= arr[right])
            return left;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // If mid element is greater than next element, return next index
            if (arr[mid] > arr[mid + 1])
                return mid + 1;

            // If mid is less than left, move right to mid
            if (arr[mid] < arr[left])
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }

    static void Main()
    {
        int[] arr = { 4, 5, 6, 7, 0, 1, 2 };
        Console.WriteLine("Rotation point index: " + FindRotationPoint(arr));
    }
}
