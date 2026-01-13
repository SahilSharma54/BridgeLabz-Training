using System;
using System.IO;

class ByteToCharStream
{
    static void Main()
    {
        using (FileStream fs = new FileStream("sample.txt", FileMode.Open))
        using (StreamReader sr = new StreamReader(fs))
        {
            int ch;
            while ((ch = sr.Read()) != -1)
            {
                Console.Write((char)ch); // Convert byte to character and print
            }
        }
    }
}
