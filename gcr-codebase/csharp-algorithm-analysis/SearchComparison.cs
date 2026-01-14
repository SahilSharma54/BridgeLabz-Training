using System;
using System.Diagnostics;

class SearchComparison
{
    static void Main()
    {
        // SAMPLE DATA:
        // We are generating sample data 
        int size = 1000000;   // Large dataset
        int[] data = new int[size];

        // Filling array with sorted values
        for (int i = 0; i < size; i++)
        {
            data[i] = i + 1;
        }

        int target = size; // Target value to search

        // Stopwatch to measure time
        Stopwatch sw = new Stopwatch();

        // LINEAR SEARCH 
        sw.Start();
        LinearSearch(data, target);
        sw.Stop();
        Console.WriteLine("Linear Search Time: " + sw.ElapsedMilliseconds + " ms");

        // Reset stopwatch
        sw.Reset();

        // BINARY SEARCH 
        sw.Start();
        BinarySearch(data, target);
        sw.Stop();
        Console.WriteLine("Binary Search Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // Linear Search: checks each element one by one
    static void LinearSearch(int[] arr, int target)
    {
        foreach (int num in arr)   // Using foreach 
        {
            if (num == target)
                return;
        }
    }

    // Binary Search: works only on sorted data
    static void BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
    }
}
