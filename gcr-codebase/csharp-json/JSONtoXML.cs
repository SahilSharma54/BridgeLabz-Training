using System;
using Newtonsoft.Json;
using System.Xml.Linq;

class JSONtoXML
{
    static void Main()
    {
        Console.WriteLine("Enter JSON:");
        string json = Console.ReadLine();

        XNode node = JsonConvert.DeserializeXNode(json, "Root");

        Console.WriteLine("\nXML Output:");
        Console.WriteLine(node.ToString());
    }
}
