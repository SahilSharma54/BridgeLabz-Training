using System;
using System.Collections.Generic;

class ReverseQueueDemo
{
    // Recursive function to reverse queue
    static void ReverseQueue(Queue<int> q)
    {
        // Base case
        if (q.Count == 0)
            return;

        // Remove front element
        int front = q.Dequeue();

        // Reverse remaining queue
        ReverseQueue(q);

        // Insert element at rear
        q.Enqueue(front);
    }

    static void Main()
    {
        Queue<int> queue = new Queue<int>();

        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            queue.Enqueue(int.Parse(Console.ReadLine()));

        ReverseQueue(queue);

        Console.WriteLine("Reversed Queue:");
        foreach (int i in queue)
            Console.Write(i + " ");
    }
}
