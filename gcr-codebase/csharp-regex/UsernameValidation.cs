using System;
using System.Text.RegularExpressions;

class UsernameValidation
{
    static void Main()
    {
        // Ask user to enter username
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        // Regex explanation:
        // ^[A-Za-z]        -> must start with a letter
        // [A-Za-z0-9_]{4,14} -> remaining characters (total length becomes 5–15)
        // $               -> end of string
		
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        // Check if username matches the pattern
        if (Regex.IsMatch(username, pattern))
        {
            Console.WriteLine("Valid Username");
        }
        else
        {
            Console.WriteLine("Invalid Username");
        }
    }
}
