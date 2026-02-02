using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        // Ask user for name
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        // Ask user for age
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        // Ask user for subjects
        List<string> subjects = new List<string>();
        Console.Write("How many subjects? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter subject " + (i + 1) + ": ");
            subjects.Add(Console.ReadLine());
        }

        // Create object
        var student = new
        {
            Name = name,
            Age = age,
            Subjects = subjects
        };

        // Convert to JSON
        string json = JsonConvert.SerializeObject(student, Formatting.Indented);

        // Print JSON
        Console.WriteLine("\nGenerated JSON:");
        Console.WriteLine(json);
    }
}
