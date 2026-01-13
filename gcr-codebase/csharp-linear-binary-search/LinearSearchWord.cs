using System;

class LinearSearchWord
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sentences:");
        int n = int.Parse(Console.ReadLine());
        string[] sentences = new string[n];

        Console.WriteLine("Enter the sentences:");
        for (int i = 0; i < n; i++)
        {
            sentences[i] = Console.ReadLine();
        }

        Console.WriteLine("Enter the word to search:");
        string word = Console.ReadLine();

        int index = -1;
        for (int i = 0; i < n; i++)
        {
            if (sentences[i].Contains(word)) // check if sentence contains the word
            {
                index = i;
                break;
            }
        }

        if (index != -1)
            Console.WriteLine("First sentence containing the word is: " + sentences[index]);
        else
            Console.WriteLine("Word not found in any sentence.");
    }
}
