using System;
using System.IO;

class ReadLargeCSV
{
    static void Main()
    {
        int count = 0;

        // Create StreamReader
        StreamReader sr = new StreamReader("SampleData.csv");

        // Skip header line
        sr.ReadLine();

        // Read each line one by one
        while (!sr.EndOfStream)
        {
            sr.ReadLine();
            count++;
        }

        // Close the reader
        sr.Close();

        // Display total records
        Console.WriteLine("Total records processed: " + count);
    }
}
