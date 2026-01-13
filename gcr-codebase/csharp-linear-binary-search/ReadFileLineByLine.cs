using System;
using System.IO;

class ReadFileLineByLine
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("sample.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line); // Print each line
            }
        }
    }
}
