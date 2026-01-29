using System;
using System.IO;

class SearchCSV
{
    static void Main()
    {
        // Take employee name from user
        Console.Write("Enter employee name: ");
        string name = Console.ReadLine();

        // Read all lines from CSV file
        string[] lines = File.ReadAllLines("SampleData.csv");

        // Start from 1 to skip header row
        for (int i = 1; i < lines.Length; i++)
        {
            // Split each line
            string[] data = lines[i].Split(',');

            // Compare names (case-insensitive)
            if (data[1].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                // Display department and salary using concatenation
                Console.WriteLine(
                    "Department: " + data[2] +
                    ", Salary: " + data[3]
                );
                return;
            }
        }

        // If employee not found
        Console.WriteLine("Employee not found");
    }
}
