using System;
using System.Collections;

class ZeroSumSubArray
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Hashtable map = new Hashtable();
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];

            if (arr[i] == 0 || sum == 0 || map.ContainsKey(sum))
            {
                Console.WriteLine("Zero sum subarray exists");
                return;
            }

            map[sum] = true;
        }

        Console.WriteLine("No zero sum subarray");
    }
}
