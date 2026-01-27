using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        // Take input text from user
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Regex for basic email extraction
        string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        // Find all matches
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Email Addresses:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
