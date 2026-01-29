using System;
using System.IO;

class SortCSV
{
    static void Main()
    {
        // Read all lines from CSV file
        string[] lines = File.ReadAllLines("SampleData.csv");

        Console.WriteLine("Top 5 Highest Paid Employees:");

        // Simple sorting using loops (based on salary)
        for (int i = 1; i < lines.Length - 1; i++)
        {
            for (int j = i + 1; j < lines.Length; j++)
            {
                string[] data1 = lines[i].Split(',');
                string[] data2 = lines[j].Split(',');

                double salary1 = double.Parse(data1[3]);
                double salary2 = double.Parse(data2[3]);

                // Sort in descending order
                if (salary1 < salary2)
                {
                    string temp = lines[i];
                    lines[i] = lines[j];
                    lines[j] = temp;
                }
            }
        }

        // Print top 5 records (skip header)
        int count = 0;
        for (int i = 1; i < lines.Length && count < 5; i++)
        {
            string[] data = lines[i].Split(',');

            Console.WriteLine(data[1] + " - " + data[3]);
            count++;
        }
    }
}
