using System;
using System.IO;
using System.Text;

class UpperToLower
{
    static void Main()
    {
        Console.Write("Enter source text file path: ");
        string source = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        string destination = Console.ReadLine();

        try
        {
            // StreamReader with UTF-8 encoding
            StreamReader reader = new StreamReader(source, Encoding.UTF8);
            StreamWriter writer = new StreamWriter(destination, false, Encoding.UTF8);

            string line;
            // Read file line by line
            while ((line = reader.ReadLine()) != null)
            {
                // Convert uppercase to lowercase
                writer.WriteLine(line.ToLower());
            }

            reader.Close();
            writer.Close();

            Console.WriteLine("Conversion completed successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
