using System;
using System.Collections.Generic;

class SymmetricDifference
{
    static void Main()
    {
        // Input for Set 1 
        Console.Write("Enter number of elements for Set 1: ");
        int n1 = int.Parse(Console.ReadLine());

        HashSet<int> set1 = new HashSet<int>();
        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            set1.Add(int.Parse(Console.ReadLine()));
        }

        // Input for Set 2 
        Console.Write("\nEnter number of elements for Set 2: ");
        int n2 = int.Parse(Console.ReadLine());

        HashSet<int> set2 = new HashSet<int>();
        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            set2.Add(int.Parse(Console.ReadLine()));
        }

        // Symmetric Difference
        set1.SymmetricExceptWith(set2);

        Console.WriteLine("\nSymmetric Difference:");
        foreach (int i in set1)
            Console.Write(i + " ");
    }
}
