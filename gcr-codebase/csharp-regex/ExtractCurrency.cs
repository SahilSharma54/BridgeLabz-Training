using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        // Input text
        Console.Write("Enter text with prices: ");
        string text = Console.ReadLine();

        // Regex for dollar currency
        string pattern = @"\$\d+(\.\d{2})?";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Extracted Currency Values:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
