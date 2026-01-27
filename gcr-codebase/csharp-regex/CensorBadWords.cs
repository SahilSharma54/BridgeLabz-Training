using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    static void Main()
    {
        // Input sentence
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        // List of bad words (simple example)
        string pattern = @"\b(damn|stupid)\b";

        // Replace bad words with ****
        string result = Regex.Replace(text, pattern, "****", RegexOptions.IgnoreCase);

        Console.WriteLine("Censored Sentence:");
        Console.WriteLine(result);
    }
}
