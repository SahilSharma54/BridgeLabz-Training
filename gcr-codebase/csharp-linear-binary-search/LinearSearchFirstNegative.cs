using System;

class LinearSearchFirstNegative
{
    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int index = -1;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0) // check if number is negative
            {
                index = i;
                break; // stop at first negative
            }
        }

        if (index != -1)
            Console.WriteLine("First negative number is " + arr[index] + " at index " + index);
        else
            Console.WriteLine("No negative number found in the array.");
    }
}
