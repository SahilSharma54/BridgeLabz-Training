using System;
using Newtonsoft.Json.Linq;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON Array:");
        JArray users = JArray.Parse(Console.ReadLine());

        var filtered = users.Where(u => (int)u["Age"] > 25);

        Console.WriteLine("\nUsers Above 25:");
        Console.WriteLine(JArray.FromObject(filtered));
    }
}
