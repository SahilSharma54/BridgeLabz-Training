using System;
using System.IO;

class ReadLargeFile
{
    static void Main()
    {
        Console.Write("Enter large file path: ");
        string path = Console.ReadLine();

        try
        {
            StreamReader reader = new StreamReader(path);
            string line;

            // Read file line by line
            while ((line = reader.ReadLine()) != null)
            {
                // Check for word "error" (case insensitive)
                if (line.ToLower().Contains("error"))
                {
                    Console.WriteLine(line);
                }
            }

            reader.Close();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
