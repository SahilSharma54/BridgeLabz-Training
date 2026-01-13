using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Create a StringBuilder with the input
        StringBuilder sb = new StringBuilder(input);

        // Reverse the string
        for (int i = 0, j = sb.Length - 1; i < j; i++, j--)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }

        Console.WriteLine("Reversed string: " + sb.ToString());
    }
}
