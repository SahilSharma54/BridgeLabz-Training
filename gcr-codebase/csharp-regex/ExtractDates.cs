using System;
using System.Text.RegularExpressions;

class ExtractDates
{
    static void Main()
    {
        // Take input text from user
        Console.Write("Enter text with dates: ");
        string text = Console.ReadLine();

        // Regex explanation:
        // \b            -> word boundary
        // \d{2}/\d{2}/\d{4} -> date format dd/mm/yyyy
		
        string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

        // Find all dates
        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Dates:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
