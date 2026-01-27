using System;
using System.Text.RegularExpressions;

class ExtractLinks
{
    static void Main()
    {
        // Take input text from user
        Console.Write("Enter text with links: ");
        string text = Console.ReadLine();

        // Regex explanation:
        // https?:// -> matches http:// or https://
        // \S+       -> matches remaining characters of URL
		
        string pattern = @"https?://\S+";

        // Find all links
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Links:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
