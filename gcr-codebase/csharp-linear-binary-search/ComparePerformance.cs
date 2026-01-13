using System;
using System.Text;
using System.Diagnostics;

class ComparePerformance
{
    static void Main()
    {
        int iterations = 10000;
        string[] words = { "Hello", "World", "CSharp", "StringBuilder" };

        // Using String
        Stopwatch sw1 = Stopwatch.StartNew();
        string result1 = "";
        for (int i = 0; i < iterations; i++)
        {
            foreach (string word in words)
                result1 += word;
        }
        sw1.Stop();
        Console.WriteLine("Time using string concatenation: " + sw1.ElapsedMilliseconds + " ms");

        // Using StringBuilder
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++)
        {
            foreach (string word in words)
                sb.Append(word);
        }
        sw2.Stop();
        Console.WriteLine("Time using StringBuilder: " + sw2.ElapsedMilliseconds + " ms");
    }
}
