using System;
using System.IO;

class FileNotFoundDemo
{
    static void Main()
    {
        // Ask user to enter file name
        Console.Write("Enter file name (with extension): ");
        string fileName = Console.ReadLine();

        try
        {
            // Try to read the file entered by the user
            string content = File.ReadAllText(fileName);

            // If file exists, print contents
            Console.WriteLine("\nFile Content:");
            Console.WriteLine(content);
        }
        catch (IOException)
        {
            // If file does not exist or cannot be accessed
            Console.WriteLine("\nFile not found");
        }
    }
}
