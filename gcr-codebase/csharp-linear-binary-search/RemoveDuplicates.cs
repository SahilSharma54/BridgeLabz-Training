using System;
using System.Text;

class RemoveDuplicates
{
    static void Main()
    {
        // Ask the user for input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder();

        // Loop through each character in the input
        foreach (char c in input)
        {
            // Check if the character is already in the StringBuilder
            if (!sb.ToString().Contains(c.ToString()))
            {
                sb.Append(c); // Append if not present
            }
        }

        // Display the result
        Console.WriteLine("String after removing duplicates: " + sb.ToString());
    }
}
