using System;
using System.Text.RegularExpressions;

class RepeatingWords
{
    static void Main()
    {
        // Input sentence
        Console.Write("Enter a sentence: ");
        string text = Console.ReadLine();

        // Regex explanation:
        // (\b\w+\b) -> captures a word
        // \s+\1     -> same word repeated
        string pattern = @"\b(\w+)\b\s+\1\b";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        Console.WriteLine("Repeating Words:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[1].Value);
        }
    }
}
