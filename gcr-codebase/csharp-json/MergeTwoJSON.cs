using System;
using Newtonsoft.Json.Linq;

class MergeTwoJSON
{
    static void Main()
    {
        Console.WriteLine("Enter first JSON:");
        JObject j1 = JObject.Parse(Console.ReadLine());

        Console.WriteLine("Enter second JSON:");
        JObject j2 = JObject.Parse(Console.ReadLine());

        j1.Merge(j2);

        Console.WriteLine("\nMerged JSON:");
        Console.WriteLine(j1);
    }
}
