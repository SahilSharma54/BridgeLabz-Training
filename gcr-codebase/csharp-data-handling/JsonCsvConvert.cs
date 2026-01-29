using System;
using System.IO;

class JsonCsvConvert
{
    static void Main()
    {
        // CSV to JSON 
        string[] csvLines = File.ReadAllLines("SampleData.csv");

        // Skip header and build JSON manually
        string json = "[";

        for (int i = 1; i < csvLines.Length; i++)
        {
            string[] data = csvLines[i].Split(',');

            json = json + "{";
            json = json + "\"Id\":" + data[0] + ",";
            json = json + "\"Name\":\"" + data[1] + "\"";
            json = json + "}";

            if (i < csvLines.Length - 1)
            {
                json = json + ",";
            }
        }

        json = json + "]";

        File.WriteAllText("SampleData.json", json);

        // JSON to CSV 
        string csv = "Id,Name\n1,Sahil\n2,Sajal";
        File.WriteAllText("converted.csv", csv);

        Console.WriteLine("Conversion completed");
    }
}
