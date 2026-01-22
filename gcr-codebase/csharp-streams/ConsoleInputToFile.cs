using System;
using System.IO;

class ConsoleInputToFile
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string age = Console.ReadLine();

        Console.Write("Enter your favorite programming language: ");
        string language = Console.ReadLine();

        try
        {
            StreamWriter writer = new StreamWriter("SampleSource.txt");

            writer.WriteLine("Name: " + name);
            writer.WriteLine("Age: " + age);
            writer.WriteLine("Favorite Language: " + language);

            writer.Close();

            Console.WriteLine("Data saved to file successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
