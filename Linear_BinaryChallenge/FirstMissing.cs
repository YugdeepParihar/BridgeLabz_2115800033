using System;

class LinearSearchProgram
{
    
    static int FindFirstMissing(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                // Swap arr[i] with arr[arr[i] - 1]
                int temp = arr[i];
                arr[i] = arr[arr[i] - 1];
                arr[arr[i] - 1] = temp;
            }
        }

        // Find the first missing positive number
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
                return i + 1;
        }

        return n + 1;
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

        
        int missing = FindFirstMissing(arr);
        Console.WriteLine("First missing positive integer: " + missing);
    }
}
