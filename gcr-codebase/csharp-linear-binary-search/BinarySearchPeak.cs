using System;

class BinarySearchPeak
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int left = 0, right = n - 1;
        int peak = -1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            bool leftOk = (mid == 0 || arr[mid] >= arr[mid - 1]);
            bool rightOk = (mid == n - 1 || arr[mid] >= arr[mid + 1]);

            if (leftOk && rightOk)
            {
                peak = mid;
                break;
            }
            else if (mid > 0 && arr[mid - 1] > arr[mid])
                right = mid - 1;
            else
                left = mid + 1;
        }

        Console.WriteLine("Peak element is " + arr[peak] + " at index " + peak);
    }
}
