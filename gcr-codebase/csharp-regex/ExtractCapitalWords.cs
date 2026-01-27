using System;
using System.Text.RegularExpressions;

class ExtractCapitalWords
{
    static void Main()
    {
        // Take sentence input from user
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        // Regex explanation:
        // \b       -> word boundary
        // [A-Z]    -> first letter capital
        // [a-z]*   -> remaining lowercase letters
		
        string pattern = @"\b[A-Z][a-z]*\b";

        // Find all capitalized words
        MatchCollection matches = Regex.Matches(sentence, pattern);

        Console.WriteLine("Capitalized Words:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
