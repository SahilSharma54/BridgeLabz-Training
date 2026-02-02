using System;
using System.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON Array:");
        JArray array = JArray.Parse(Console.ReadLine());

        var result = array.Where(x => (int)x["Age"] > 25);

        Console.WriteLine("\nFiltered Data:");
        Console.WriteLine(JArray.FromObject(result));
    }
}
