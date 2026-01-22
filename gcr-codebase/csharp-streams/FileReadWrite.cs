using System;
using System.IO;

class FileReadWrite
{
    static void Main()
    {
        Console.Write("Enter source file path: ");
        string sourcePath = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        string destPath = Console.ReadLine();

        try
        {
            // Check if source file exists
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            // Open source file for reading
            FileStream readStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read);

            // Create destination file
            FileStream writeStream = new FileStream(destPath, FileMode.Create, FileAccess.Write);

            int data;
            // Read byte by byte and write to destination
            while ((data = readStream.ReadByte()) != -1)
            {
                writeStream.WriteByte((byte)data);
            }

            readStream.Close();
            writeStream.Close();

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("IO Error: " + e.Message);
        }
    }
}
