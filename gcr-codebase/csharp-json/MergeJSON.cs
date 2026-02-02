using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter first JSON:");
        JObject json1 = JObject.Parse(Console.ReadLine());

        Console.WriteLine("Enter second JSON:");
        JObject json2 = JObject.Parse(Console.ReadLine());

        // Merge JSON
        json1.Merge(json2);

        Console.WriteLine("\nMerged JSON:");
        Console.WriteLine(json1.ToString());
    }
}
