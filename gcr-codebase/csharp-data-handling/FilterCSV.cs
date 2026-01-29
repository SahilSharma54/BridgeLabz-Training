using System;
using System.IO;

class FilterCSV
{
    static void Main()
    {
        // Read all lines from CSV file
        string[] lines = File.ReadAllLines("SampleData.csv");

        Console.WriteLine("Students scoring more than 80:");

        // Start from 1 to skip header row
        for (int i = 1; i < lines.Length; i++)
        {
            // Split each line
            string[] data = lines[i].Split(',');

            // Convert marks column to integer
            int marks = int.Parse(data[3]);

            // Check condition
            if (marks > 80)
            {
                // Display name and marks using concatenation
                Console.WriteLine(data[1] + " - " + marks);
            }
        }
    }
}
