using System;
using System.Text.RegularExpressions;

class ReplaceSpaces
{
    static void Main()
    {
        // Take input text from user
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Regex explanation:
        // \s+ -> matches one or more spaces
        string result = Regex.Replace(text, @"\s+", " ");

        Console.WriteLine("After Replacing Spaces:");
        Console.WriteLine(result);
    }
}
