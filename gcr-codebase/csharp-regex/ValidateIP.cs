using System;
using System.Text.RegularExpressions;

class ValidateIP
{
    static void Main()
    {
        // Input IP address
        Console.Write("Enter IP address: ");
        string ip = Console.ReadLine();

        // Regex for IPv4 validation (0–255)
        string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}"
                       + @"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

        if (Regex.IsMatch(ip, pattern))
            Console.WriteLine("Valid IP Address");
        else
            Console.WriteLine("Invalid IP Address");
    }
}
