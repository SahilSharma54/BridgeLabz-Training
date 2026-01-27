using System;
using System.Text.RegularExpressions;

class HexColorValidation
{
    static void Main()
    {
        // Ask user to enter hex color code
        Console.Write("Enter hex color code: ");
        string color = Console.ReadLine();

        // Regex explanation:
        // ^#           -> must start with #
        // [0-9A-Fa-f]{6} -> exactly 6 hexadecimal characters
        // $            -> end of string
		
        string pattern = @"^#[0-9A-Fa-f]{6}$";

        // Validate hex color code
        if (Regex.IsMatch(color, pattern))
        {
            Console.WriteLine("Valid Hex Color Code");
        }
        else
        {
            Console.WriteLine("Invalid Hex Color Code");
        }
    }
}
