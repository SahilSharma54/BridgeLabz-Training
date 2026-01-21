using System;
using System.Collections.Generic;

class WordFrequency
{
    static void Main()
    {
        Dictionary<string, int> freq = new Dictionary<string, int>();

        Console.Write("Enter text: ");
        string text = Console.ReadLine().ToLower();

        string[] words = text.Split(' ', ',', '.', '!', '?');

        foreach (string word in words)
        {
            if (word == "") continue;

            if (freq.ContainsKey(word))
                freq[word]++;
            else
                freq[word] = 1;
        }

        Console.WriteLine("\nWord Frequencies:");
        foreach (var pair in freq)
            Console.WriteLine(pair.Key + " : " + pair.Value);
    }
}
