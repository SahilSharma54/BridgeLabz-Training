using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON:");
        JObject obj = JObject.Parse(Console.ReadLine());

        foreach (var item in obj)
        {
            Console.WriteLine(item.Key + " : " + item.Value);
        }
    }
}
