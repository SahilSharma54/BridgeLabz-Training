using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Suppress compiler warnings for non-generic ArrayList
#pragma warning disable
        ArrayList list = new ArrayList();
        list.Add(10);
        list.Add("Hello"); // Mixed types allowed

        Console.WriteLine("ArrayList contents:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
#pragma warning restore
    }
}
