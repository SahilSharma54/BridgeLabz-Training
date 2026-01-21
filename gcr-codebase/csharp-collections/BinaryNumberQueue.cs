using System;
using System.Collections.Generic;

class BinaryNumberQueue
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        queue.Enqueue("1");

        Console.Write("Binary Numbers:");
        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();
            Console.Write(current + " ");

            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }
    }
}
