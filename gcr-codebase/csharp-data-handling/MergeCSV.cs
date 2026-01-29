using System;
using System.IO;

class MergeCSV
{
    static void Main()
    {
        // Read both CSV files
        string[] file1 = File.ReadAllLines("SampleData.csv");
        string[] file2 = File.ReadAllLines("employees.csv");

        // Create merged CSV file
        StreamWriter sw = new StreamWriter("merged.csv");

        // Write header
        sw.WriteLine("ID,Name,Age,Marks,Grade");

        // Loop through first CSV (skip header)
        for (int i = 1; i < file1.Length; i++)
        {
            string[] data1 = file1[i].Split(',');

            // Loop through second CSV (skip header)
            for (int j = 1; j < file2.Length; j++)
            {
                string[] data2 = file2[j].Split(',');

                // Match by ID
                if (data1[0] == data2[0])
                {
                    // Merge and write data
                    sw.WriteLine(
                        data1[0] + "," +
                        data1[1] + "," +
                        data1[2] + "," +
                        data2[1] + "," +
                        data2[2]
                    );
                    break;
                }
            }
        }

        // Close writer
        sw.Close();

        Console.WriteLine("CSV merged successfully");
    }
}
