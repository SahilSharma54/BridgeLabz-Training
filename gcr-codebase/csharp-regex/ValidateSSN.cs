using System;
using System.Text.RegularExpressions;

class ValidateSSN
{
    static void Main()
    {
        // Input SSN
        Console.Write("Enter SSN: ");
        string ssn = Console.ReadLine();

        // SSN format: 123-45-6789
        string pattern = @"^\d{3}-\d{2}-\d{4}$";

        if (Regex.IsMatch(ssn, pattern))
            Console.WriteLine(ssn + " is valid");
        else
            Console.WriteLine(ssn + " is invalid");
    }
}
