using System;

class BinarySearchFirstLast
{
    static int FirstOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                right = mid - 1; // move left to find first
            }
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return result;
    }

    static int LastOccurrence(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, result = -1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                left = mid + 1; // move right to find last
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
        Console.WriteLine("Enter number of elements in the sorted array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements in sorted order:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the target element:");
        int target = int.Parse(Console.ReadLine());

        int first = FirstOccurrence(arr, target);
        int last = LastOccurrence(arr, target);

        if (first != -1)
            Console.WriteLine("First occurrence at index: " + first + ", Last occurrence at index: " + last);
        else
            Console.WriteLine("Element not found in the array.");
    }
}
