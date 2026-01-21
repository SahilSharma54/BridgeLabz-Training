using System;
using System.Collections;
using System.Collections.Generic;

class ReverseListDemo
{
    static void ReverseArrayList(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;

        // Swap elements till middle
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;

            left++;
            right--;
        }
    }

    static LinkedList<int> ReverseLinkedList(LinkedList<int> list)
    {
        LinkedList<int> reversed = new LinkedList<int>();

        // Add elements at beginning
        foreach (int item in list)
            reversed.AddFirst(item);

        return reversed;
    }

    static void Main()
    {
        // ArrayList Input 
        ArrayList arr = new ArrayList();

        Console.Write("Enter number of elements for ArrayList: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }

        ReverseArrayList(arr);

        Console.WriteLine("Reversed ArrayList:");
        foreach (var i in arr)
            Console.Write(i + " ");

        // LinkedList Input 
        Console.Write("\n\nEnter number of elements for LinkedList: ");
        int m = int.Parse(Console.ReadLine());

        LinkedList<int> ll = new LinkedList<int>();

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < m; i++)
        {
            ll.AddLast(int.Parse(Console.ReadLine()));
        }

        ll = ReverseLinkedList(ll);

        Console.WriteLine("Reversed LinkedList:");
        foreach (var i in ll)
            Console.Write(i + " ");
    }
}
