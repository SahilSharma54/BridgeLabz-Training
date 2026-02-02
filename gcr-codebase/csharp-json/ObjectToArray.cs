using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        Console.Write("How many people? ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Person p = new Person();

            Console.Write("Enter name: ");
            p.Name = Console.ReadLine();

            Console.Write("Enter age: ");
            p.Age = int.Parse(Console.ReadLine());

            people.Add(p);
        }

        // Convert list to JSON array
        string json = JsonConvert.SerializeObject(people, Formatting.Indented);

        Console.WriteLine("\nJSON Array:");
        Console.WriteLine(json);
    }
}
