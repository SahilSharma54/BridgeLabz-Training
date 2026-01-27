using System;
using System.Text.RegularExpressions;

class ValidateCreditCard
{
    static void Main()
    {
        // Input card number
        Console.Write("Enter credit card number: ");
        string card = Console.ReadLine();

        // Visa: starts with 4, 16 digits
        // MasterCard: starts with 5, 16 digits
        string pattern = @"^(4\d{15}|5\d{15})$";

        if (Regex.IsMatch(card, pattern))
            Console.WriteLine("Valid Credit Card Number");
        else
            Console.WriteLine("Invalid Credit Card Number");
    }
}
