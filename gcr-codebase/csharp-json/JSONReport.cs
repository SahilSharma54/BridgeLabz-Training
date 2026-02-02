using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class JSONReport
{
    static void Main()
    {
        // Simulated database records
        var records = new List<object>
        {
            new { ID = 1, Name = "Sahil", Score = 90 },
            new { ID = 2, Name = "Sajal", Score = 85 }
        };

        string json = JsonConvert.SerializeObject(records, Formatting.Indented);

        Console.WriteLine("JSON Report:");
        Console.WriteLine(json);
    }
}
