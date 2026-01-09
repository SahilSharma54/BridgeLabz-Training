using System;
using System.Collections;

class LongestConsecutiveSequence
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Hashtable map = new Hashtable();

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
            map[arr[i]] = true; // Store all elements
        }

        int longest = 0;

        for (int i = 0; i < n; i++)
        {
            // Check if current number is start of sequence
            if (!map.ContainsKey(arr[i] - 1))
            {
                int current = arr[i];
                int count = 1;

                // Count consecutive numbers
                while (map.ContainsKey(current + 1))
                {
                    current++;
                    count++;
                }

                if (count > longest)
                    longest = count;
            }
        }

        Console.WriteLine("Longest consecutive sequence length: " + longest);
    }
}
