using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        Console.Write("How many words do you want to enter? ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        // Get words from the user
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter word " + (i + 1) + ": ");
            words[i] = Console.ReadLine();
        }

        StringBuilder sb = new StringBuilder();

        // Append each word to StringBuilder
        foreach (string word in words)
        {
            sb.Append(word); // Efficient concatenation
        }

        Console.WriteLine("Concatenated string: " + sb.ToString());
    }
}
