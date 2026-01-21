using System;
using System.Collections.Generic;

class NthFromEnd
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            list.AddLast(Console.ReadLine());

        Console.Write("Enter N (from end): ");
        int N = int.Parse(Console.ReadLine());

        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        // Move first pointer N steps ahead
        for (int i = 0; i < N; i++)
            first = first.Next;

        // Move both pointers
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        Console.WriteLine("Nth Element from End: " + second.Value);
    }
}
