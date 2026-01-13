using System;

class BinarySearchTarget
{
    static void Main()
    {
        // Menu driven approach
        Console.WriteLine("1. Binary Search for Target Number");
        Console.WriteLine("2. Exit");
        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter the number of elements in the list: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the list:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Console.Write("Enter the target number to search: ");
            int target = int.Parse(Console.ReadLine());

            // Sort array for binary search
            Array.Sort(arr);

            // Call function to find target index
            int index = BinarySearch(arr, target);
            if (index != -1)
                Console.WriteLine("Target found at index: " + index);
            else
                Console.WriteLine("Target not found in the list.");
        }
        else
        {
            Console.WriteLine("Exiting program...");
        }
    }

    // Function to perform binary search
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1; // Target not found
    }
}
