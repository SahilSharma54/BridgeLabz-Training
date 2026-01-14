using System;
using System.Diagnostics;
using System.IO;

class FileReadingTest
{
    static void Main()
    {
        string filePath = "sample.txt";

        Stopwatch watch = new Stopwatch();

        // Reading using StreamReader
        watch.Start();
        ReadByStreamReader(filePath);
        watch.Stop();
        Console.WriteLine("StreamReader Time: " + watch.ElapsedMilliseconds + " ms");

        watch.Reset();

        // Reading using FileStream 
        watch.Start();
        ReadByFileStream(filePath);
        watch.Stop();
        Console.WriteLine("FileStream Time: " + watch.ElapsedMilliseconds + " ms");
    }

    // Reads file line by line (simple and readable)
    static void ReadByStreamReader(string path)
    {
        StreamReader reader = new StreamReader(path);

        while (reader.ReadLine() != null)
        {
            // reading each line
        }

        reader.Close();
    }

    // Reads file as bytes (low-level reading)
    static void ReadByFileStream(string path)
    {
        FileStream fs = new FileStream(path, FileMode.Open);

        byte[] buffer = new byte[1024];
        int bytesRead;

        while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
        {
            // Reading bytes from file
        }

        fs.Close();
    }
}
