using System;
using System.IO;

class CountCSVRows
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("SampleData.csv");

        int count = lines.Length - 1; // exclude header
        Console.WriteLine("Total records: " + count);
    }
}
