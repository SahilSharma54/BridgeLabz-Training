using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class WordCount
{
    static void Main()
    {
        Console.Write("Enter text file path: ");
        string path = Console.ReadLine();

        try
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            StreamReader reader = new StreamReader(path);
            string line;

            while ((line = reader.ReadLine()) != null)
            {
                // Split words
                string[] words = line.Split(' ', ',', '.', '!', '?');

                foreach (string word in words)
                {
                    string w = word.ToLower();

                    if (w != "")
                    {
                        if (wordCount.ContainsKey(w))
                            wordCount[w]++;
                        else
                            wordCount[w] = 1;
                    }
                }
            }

            reader.Close();

            // Sort and display top 5 words
            Console.WriteLine("\nTop 5 Frequent Words:");
            foreach (var item in wordCount.OrderByDescending(x => x.Value).Take(5))
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
