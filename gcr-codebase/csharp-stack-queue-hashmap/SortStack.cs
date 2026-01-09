using System;
using System.Collections;

class SortStack
{
    static Stack stack = new Stack();

    static void SortedInsert(int x)
    {
        // Insert element at correct position
        if (stack.Count == 0 || x > (int)stack.Peek())
        {
            stack.Push(x);
            return;
        }

        int temp = (int)stack.Pop();
        SortedInsert(x);
        stack.Push(temp);
    }

    static void Sort()
    {
        if (stack.Count > 0)
        {
            int x = (int)stack.Pop();
            Sort();
            SortedInsert(x);
        }
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            stack.Push(int.Parse(Console.ReadLine()));
        }

        Sort();

        Console.WriteLine("Sorted Stack:");
        foreach (int item in stack)
            Console.WriteLine(item);
    }
}
