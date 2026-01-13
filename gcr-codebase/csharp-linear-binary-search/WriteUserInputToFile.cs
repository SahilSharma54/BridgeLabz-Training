using System;
using System.IO;

class WriteUserInputToFile
{
    static void Main()
    {
        Console.Write("Enter text to write to file: ");
        string input = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            sw.WriteLine(input); // Write user input to file
        }

        Console.WriteLine("Text written to output.txt successfully.");
    }
}
