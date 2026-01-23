using System;
using System.IO;

class UsingStatementFile
{
    static void Main()
    {
        // Ask user to enter file name
        Console.Write("Enter file name (with extension): ");
        string fileName = Console.ReadLine();

        try
        {
            // using ensures file is closed automatically
            using (StreamReader reader = new StreamReader(fileName))
            {
                // Read first line from the file
                string firstLine = reader.ReadLine();
                Console.WriteLine("First Line: " + firstLine);
            }
        }
        catch (IOException)
        {
            // If file is not found or cannot be read
            Console.WriteLine("Error reading file OR Not Found");
        }
    }
}
