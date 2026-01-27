using System;
using System.Text.RegularExpressions;

class LicensePlateValidation
{
    static void Main()
    {
        // Ask user to enter license plate number
        Console.Write("Enter license plate number: ");
        string plate = Console.ReadLine();

        // Regex explanation:
        // ^[A-Z]{2} -> exactly two uppercase letters
        // [0-9]{4}  -> exactly four digits
        // $         -> end of string
        string pattern = @"^[A-Z]{2}[0-9]{4}$";

        // Validate license plate
        if (Regex.IsMatch(plate, pattern))
        {
            Console.WriteLine("Valid License Plate");
        }
        else
        {
            Console.WriteLine("Invalid License Plate");
        }
    }
}
