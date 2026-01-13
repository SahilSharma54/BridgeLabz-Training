using System;
using System.IO;

// Mostly using the inbulit functions
class CountWordOccurrence
{
    static void Main()
    {
        Console.Write("Enter the word to count: ");
        string wordToCount = Console.ReadLine();
        int count = 0;

        try
        {
            using (StreamReader sr = new StreamReader("sample.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    // Split line into words using space, ignoring empty entries
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Count occurrences (case-insensitive)
                    foreach (string word in words)
                    {
                        if (word.Equals(wordToCount, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine("The word "+wordToCount+" occurs "+count+" times in the file.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File 'sample.txt' not found!");
        }
    }
}
