using System;
using System.Collections.Generic;

class FrequencyCounter
{
    static void Main()
    {
        List<string> items = new List<string>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            items.Add(Console.ReadLine());

        Dictionary<string, int> freq = new Dictionary<string, int>();

        foreach (string item in items)
        {
            if (freq.ContainsKey(item))
                freq[item]++;
            else
                freq[item] = 1;
        }

        Console.WriteLine("\nElement Frequencies:");
        foreach (var pair in freq)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
