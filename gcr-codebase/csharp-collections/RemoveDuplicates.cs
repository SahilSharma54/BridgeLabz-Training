using System;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main()
    {
        List<int> list = new List<int>();
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            list.Add(int.Parse(Console.ReadLine()));

        foreach (int item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }

        Console.WriteLine("After Removing Duplicates:");
        foreach (int i in result)
            Console.Write(i + " ");
    }
}
