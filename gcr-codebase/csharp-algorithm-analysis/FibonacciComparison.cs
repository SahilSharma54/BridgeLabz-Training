using System;
using System.Diagnostics;

class FibonacciComparison
{
    static void Main()
    {
        // Value of N is taken manually for testing
        int n = 30;

        Stopwatch sw = new Stopwatch();

        // RECURSIVE FIBONACCI 
        sw.Start();
        int recResult = FibonacciRecursive(n);
        sw.Stop();
        Console.WriteLine("Recursive Fibonacci Result: " + recResult);
        Console.WriteLine("Recursive Time: " + sw.ElapsedMilliseconds + " ms");

        sw.Reset();

        // ITERATIVE FIBONACCI 
        sw.Start();
        int itrResult = FibonacciIterative(n);
        sw.Stop();
        Console.WriteLine("Iterative Fibonacci Result: " + itrResult);
        Console.WriteLine("Iterative Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // Recursive Fibonacci
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;

        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Iterative Fibonacci
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1, sum = 0;

        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }

        return b;
    }
}
