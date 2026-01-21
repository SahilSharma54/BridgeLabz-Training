using System;
using System.Collections.Generic;

class RotateList
{
    static void Main()
    {
        List<int> list = new List<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            list.Add(int.Parse(Console.ReadLine()));

        Console.Write("Enter rotation count: ");
        int k = int.Parse(Console.ReadLine());
        k = k % n;

        List<int> temp = list.GetRange(0, k);
        list.RemoveRange(0, k);
        list.AddRange(temp);

        Console.WriteLine("Rotated List:");
        foreach (int i in list)
            Console.Write(i + " ");
    }
}
