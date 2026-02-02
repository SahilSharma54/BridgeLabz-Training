using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON:");

        string input = Console.ReadLine();

        try
        {
            // Try parsing JSON
            JObject.Parse(input);

            // If successful, JSON is valid
            Console.WriteLine("JSON is valid");
        }
        catch
        {
            // If error happens, JSON is invalid
            Console.WriteLine("JSON is NOT valid");
        }
    }
}
