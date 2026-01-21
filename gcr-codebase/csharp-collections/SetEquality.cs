using System;
using System.Collections.Generic;

class SetEquality
{
    static void Main()
    {
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        Console.Write("Enter number of elements in Set1: ");
        int n1 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n1; i++)
            set1.Add(int.Parse(Console.ReadLine()));

        Console.Write("Enter number of elements in Set2: ");
        int n2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n2; i++)
            set2.Add(int.Parse(Console.ReadLine()));

        // Check equality
        bool isEqual = set1.SetEquals(set2);

        Console.WriteLine("Are sets equal? " + isEqual);
    }
}
