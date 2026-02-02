using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON:");
        string json = Console.ReadLine();

        // Parse JSON
        JObject obj = JObject.Parse(json);

        // Get specific fields
        Console.WriteLine("\nExtracted Data:");
        Console.WriteLine("Name: " + obj["name"]);
        Console.WriteLine("Email: " + obj["email"]);
    }
}
