using System;
using System.Collections.Generic;

class InvertMap
{
    static void Main()
    {
        Dictionary<string, int> map = new Dictionary<string, int>();

        Console.Write("Enter number of entries: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            map[key] = value;
        }

        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

        foreach (var pair in map)
        {
            if (!inverted.ContainsKey(pair.Value))
                inverted[pair.Value] = new List<string>();

            inverted[pair.Value].Add(pair.Key);
        }

        Console.WriteLine("\nInverted Map:");
        foreach (var pair in inverted)
        {
            Console.Write(pair.Key + " : ");
            foreach (string k in pair.Value)
                Console.Write(k + " ");
            Console.WriteLine();
        }
    }
}
