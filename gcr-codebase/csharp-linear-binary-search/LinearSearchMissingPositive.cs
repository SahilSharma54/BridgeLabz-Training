using System;

class LinearSearchMissingPositive
{
    static void Main()
    {
        // Menu driven approach
        Console.WriteLine("1. Find First Missing Positive Integer");
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

            // Call function to find missing positive integer
            int missing = FindMissingPositive(arr);
            Console.WriteLine("The first missing positive integer is: " + missing);
        }
        else
        {
            Console.WriteLine("Exiting program...");
        }
    }

    // Function to find first missing positive integer
    static int FindMissingPositive(int[] arr)
    {
        int n = arr.Length;

        // Mark numbers (use index as a marker)
        for (int i = 0; i < n; i++)
        {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i])
            {
                // Swap arr[i] with arr[arr[i]-1]
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }

        // Find first missing positive
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != i + 1)
                return i + 1;
        }

        return n + 1;
    }
}
