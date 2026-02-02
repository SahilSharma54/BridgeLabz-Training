using System;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter JSON:");

        try
        {
            // Parse JSON
            JObject obj = JObject.Parse(Console.ReadLine());

            string email = null;

            // Check if email field exists
            if (obj["email"] != null)
            {
                email = obj["email"].ToString();
            }

            if (email == null)
            {
                Console.WriteLine("Email field not found");
                return;
            }

            // Simple email pattern
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Check if email is valid
            bool isValid = Regex.IsMatch(email, pattern);

            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        }
        catch
        {
            Console.WriteLine("Invalid JSON format");
        }
    }
}
