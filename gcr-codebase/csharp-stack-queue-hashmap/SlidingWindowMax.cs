using System;
using System.Collections;

class SlidingWindowMax
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter window size: ");
        int k = int.Parse(Console.ReadLine());

        Queue q = new Queue();

        for (int i = 0; i < n; i++)
        {
            while (q.Count > 0 && arr[(int)q.Peek()] <= arr[i])
                q.Dequeue();

            q.Enqueue(i);

            if ((int)q.Peek() <= i - k)
                q.Dequeue();

            if (i >= k - 1)
                Console.Write(arr[(int)q.Peek()] + " ");
        }
    }
}
