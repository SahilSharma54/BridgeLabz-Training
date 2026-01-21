using System;
using System.Collections.Generic;

class VotingSystem
{
    static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>(); // Store votes
        LinkedList<string> order = new LinkedList<string>();           // Maintain insertion order

        int choice;
        do
        {
            Console.WriteLine("\n--- Voting System ---");
            Console.WriteLine("1. Cast Vote");
            Console.WriteLine("2. Show Results (Sorted)");
            Console.WriteLine("3. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Candidate Name: ");
                    string name = Console.ReadLine();

                    if (!votes.ContainsKey(name))
                    {
                        votes[name] = 1;
                        order.AddLast(name);
                    }
                    else
                        votes[name]++;

                    Console.WriteLine("Vote casted!");
                    break;

                case 2:
                    Console.WriteLine("\nResults Sorted by Candidate Name:");
                    SortedDictionary<string, int> sorted = new SortedDictionary<string, int>(votes);
                    foreach (var pair in sorted)
                        Console.WriteLine(pair.Key + " : " + pair.Value);
                    break;
            }
        } while (choice != 3);
    }
}
