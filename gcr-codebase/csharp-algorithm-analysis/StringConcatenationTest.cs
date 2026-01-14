using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationTest
{
    static void Main()
    {
        // SAMPLE DATA:
        // We are concatenating numbers as strings 
        int count = 50000;   

        Stopwatch sw = new Stopwatch();

        // USING STRING 
        string result = "";
        sw.Start();

        for (int i = 0; i < count; i++)
        {
            // Each concatenation creates a new string object
            result = result + i;
        }

        sw.Stop();
        Console.WriteLine("String Concatenation Time: " + sw.ElapsedMilliseconds + " ms");

        sw.Reset();

        // USING STRINGBUILDER 
        StringBuilder sb = new StringBuilder();
        sw.Start();

        for (int i = 0; i < count; i++)
        {
            // StringBuilder modifies the same object
            sb.Append(i);
        }

        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
