using System;
using System.Collections.Generic;

class SetToSortedList
{
    static void Main()
    {
        HashSet<int> set = new HashSet<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            set.Add(int.Parse(Console.ReadLine()));

        // Convert to list
        List<int> list = new List<int>(set);

        // Sort list
        list.Sort();

        Console.WriteLine("Sorted List:");
        foreach (int i in list)
            Console.Write(i + " ");
    }
}
