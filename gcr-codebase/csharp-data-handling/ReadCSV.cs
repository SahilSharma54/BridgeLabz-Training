using System;
using System.IO;

class ReadCSV
{
    static void Main()
    {
        // Read all lines from CSV file
        string[] lines = File.ReadAllLines("SampleData.csv");

        // Skip header row
        for (int i = 1; i < lines.Length; i++)
        {
            // Split each line by comma
            string[] data = lines[i].Split(',');

            // Display student details using string concatenation
            Console.WriteLine(
                "ID: " + data[0] +
                ", Name: " + data[1] +
                ", Age: " + data[2] +
                ", Marks: " + data[3]
            );
        }
    }
}
