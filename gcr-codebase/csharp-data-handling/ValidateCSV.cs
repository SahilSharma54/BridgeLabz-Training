using System;
using System.IO;
using System.Text.RegularExpressions;

class ValidateCSV
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("SampleData.csv");

        // Simple email regex
        Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string email = data[1];
            string phone = data[2];

            if (!emailRegex.IsMatch(email))
            {
                Console.WriteLine("Invalid Email: " + lines[i]);
            }
            else if (phone.Length != 10)
            {
                Console.WriteLine("Invalid Phone: " + lines[i]);
            }
        }
    }
}
