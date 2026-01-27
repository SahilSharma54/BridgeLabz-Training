using System;
using System.Text.RegularExpressions;

class ExtractLanguages
{
    static void Main()
    {
        // Input text
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Regex for common programming languages
        string pattern = @"\b(Java|Python|JavaScript|Go|C|C\+\+|C#)\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Programming Languages Found:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
