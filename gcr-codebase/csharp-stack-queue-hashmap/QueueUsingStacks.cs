using System;
using System.Collections;

class QueueUsingStacks
{
    static Stack s1 = new Stack();
    static Stack s2 = new Stack();

    static void Enqueue(int value)
    {
        // Push element into first stack
        s1.Push(value);
    }

    static void Dequeue()
    {
        if (s1.Count == 0 && s2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        // Move elements only if second stack is empty
        if (s2.Count == 0)
        {
            while (s1.Count > 0)
                s2.Push(s1.Pop());
        }

        Console.WriteLine("Dequeued: " + s2.Pop());
    }

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n1.Enqueue  2.Dequeue  3.Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter value: ");
                    Enqueue(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Dequeue();
                    break;
            }
        } while (choice != 3);
    }
}
