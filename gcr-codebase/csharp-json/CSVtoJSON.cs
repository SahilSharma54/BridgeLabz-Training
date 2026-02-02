using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class CSVtoJSON
{
    static void Main()
    {
        List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            Dictionary<string, string> row = new Dictionary<string, string>();

            Console.Write("Enter Name: ");
            row["Name"] = Console.ReadLine();

            Console.Write("Enter Age: ");
            row["Age"] = Console.ReadLine();

            data.Add(row);
        }

        string json = JsonConvert.SerializeObject(data, Formatting.Indented);

        Console.WriteLine("\nJSON Output:");
        Console.WriteLine(json);
    }
}
