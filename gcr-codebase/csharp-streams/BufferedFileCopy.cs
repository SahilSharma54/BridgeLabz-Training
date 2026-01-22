using System;
using System.IO;
using System.Diagnostics;

class BufferedFileCopy
{
    static void Main()
    {
        Console.Write("Enter source file path: ");
        string source = Console.ReadLine();

        Console.Write("Enter destination file path: ");
        string destination = Console.ReadLine();

        try
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read);
            FileStream fsWrite = new FileStream(destination, FileMode.Create, FileAccess.Write);

            // Buffered streams
            BufferedStream bsRead = new BufferedStream(fsRead);
            BufferedStream bsWrite = new BufferedStream(fsWrite);

            byte[] buffer = new byte[4096]; // 4KB buffer
            int bytesRead;

            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }

            bsRead.Close();
            bsWrite.Close();

            sw.Stop();
            Console.WriteLine("Buffered copy completed.");
            Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds + " ms");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
