using System;
using System.IO;

class DetectDuplicates
{
    static void Main()
    {
        // Read all lines from CSV file
        string[] lines = File.ReadAllLines("SampleData.csv");

        Console.WriteLine("Duplicate records:");

        // Loop through records (skip header)
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data1 = lines[i].Split(',');
            string id1 = data1[0];

            // Compare with remaining records
            for (int j = i + 1; j < lines.Length; j++)
            {
                string[] data2 = lines[j].Split(',');
                string id2 = data2[0];

                // If duplicate ID found
                if (id1 == id2)
                {
                    Console.WriteLine(lines[j]);
                }
            }
        }
    }
}
