/*

Story 1: Sorting Aadhar Numbers using Radix Sort
Context: Aadhar numbers (12-digit) need to be sorted efficiently.
 Scenario A: Sort all Aadhar numbers in ascending order.
 Scenario B: Search for a particular number via binary search post-sorting.
 Scenario C: Maintain order of entries with same prefix.

*/

using System;

class AadharNumber
{
    // Function to get the maximum number from array
    static long GetMax(long[] arr, int n)
    {
        long max = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    // Counting sort used by Radix Sort (for a specific digit)
    static void CountingSort(long[] arr, int n, long exp)
    {
        long[] output = new long[n];   // output array
        int[] count = new int[10];     // digits 0–9

        // Store count of occurrences
        for (int i = 0; i < n; i++)
        {
            int digit = (int)((arr[i] / exp) % 10);
            count[digit]++;
        }

        // Change count[i] so that it contains actual position
        for (int i = 1; i < 10; i++)
        {
            count[i] += count[i - 1];
        }

        // Build output array (stable sorting)
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[count[digit] - 1] = arr[i];
            count[digit]--;
        }

        // Copy output array back to arr
        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }

    // Radix Sort function
    static void RadixSort(long[] arr, int n)
    {
        long max = GetMax(arr, n);

        // Do counting sort for every digit
        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountingSort(arr, n, exp);
        }
    }

    // Binary Search (array must be sorted)
    static int BinarySearch(long[] arr, int n, long key)
    {
        int low = 0, high = n - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }

    // Display Aadhaar numbers
    static void Display(long[] arr, int n)
    {
        Console.WriteLine("Aadhaar Numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void Main()
    {
        Console.Write("Enter number of Aadhaar entries: ");
        int n = int.Parse(Console.ReadLine());

        long[] aadhaar = new long[n];

        // Input Aadhaar numbers
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter Aadhaar number "+(i + 1)+" : ");
            aadhaar[i] = long.Parse(Console.ReadLine());
        }

        int choice;
        do
        {
            Console.WriteLine("--- MENU ---");
            Console.WriteLine("1. Sort Aadhaar Numbers (Radix Sort)");
            Console.WriteLine("2. Search Aadhaar Number (Binary Search)");
            Console.WriteLine("3. Display Aadhaar Numbers");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RadixSort(aadhaar, n);
                    Console.WriteLine("Aadhaar numbers sorted successfully.");
                    break;

                case 2:
                    Console.Write("Enter Aadhaar number to search: ");
                    long key = long.Parse(Console.ReadLine());
                    int result = BinarySearch(aadhaar, n, key);

                    if (result != -1)
                        Console.WriteLine("Aadhaar found at position"+(result + 1));
                    else
                        Console.WriteLine("Aadhaar number not found.");
                    break;

                case 3:
                    Display(aadhaar, n);
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }
}
