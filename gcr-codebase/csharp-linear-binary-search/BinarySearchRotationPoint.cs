using System;

class BinarySearchRotationPoint
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the rotated array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements of rotated sorted array:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        int left = 0, right = n - 1, rotationPoint = -1;

        while (left <= right)
        {
            if (arr[left] <= arr[right]) // array is already sorted in this range
            {
                rotationPoint = left;
                break;
            }

            int mid = (left + right) / 2;
            int next = (mid + 1) % n;
            int prev = (mid + n - 1) % n;

            if (arr[mid] <= arr[next] && arr[mid] <= arr[prev]) // minimum element
            {
                rotationPoint = mid;
                break;
            }
            else if (arr[mid] <= arr[right])
                right = mid - 1;
            else
                left = mid + 1;
        }

        Console.WriteLine("Rotation point (index of smallest element) is: " + rotationPoint);
    }
}
