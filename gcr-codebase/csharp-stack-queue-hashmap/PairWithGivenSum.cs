using System;
using System.Collections;

class PairWithGivenSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target sum: ");
        int target = int.Parse(Console.ReadLine());

        Hashtable map = new Hashtable();

        foreach (int num in arr)
        {
            // Check if required pair exists
            if (map.ContainsKey(target - num))
            {
                Console.WriteLine("Pair exists");
                return;
            }

            // Store current element
            map[num] = true;
        }

        Console.WriteLine("No such pair exists");
    }
}
