/*


Story: A fitness app tracks steps taken by each user in a small group (less than 20 people). At
the end of the day, it displays rankings. Since the list is small and frequently shuffled due to
last-minute step syncing, a simple Bubble Sort runs quickly to generate the leaderboard.
Concepts Involved:
● Bubble Sort
● Frequent updates
● Real-time re-sorting


*/

using System;

class FitnessTrack
{
    // Arrays to store user names and steps
    static string[] names = new string[20];
    static int[] steps = new int[20];
    static int count = 0; // Number of users

    static void Main()
    {
        while (true)
        {
            ShowMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddUser();
                    break;

                case 2:
                    UpdateSteps();
                    break;

                case 3:
                    SortLeaderboard();
                    DisplayLeaderboard();
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // Method to display menu
    static void ShowMenu()
    {
        Console.WriteLine("--- Fitness App Leaderboard ---");
        Console.WriteLine("1. Add User");
        Console.WriteLine("2. Update Steps");
        Console.WriteLine("3. Display Leaderboard");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    // Method to add a new user
    static void AddUser()
    {
        if (count >= 20)
        {
            Console.WriteLine("User limit reached!");
            return;
        }

        Console.Write("Enter user name: ");
        names[count] = Console.ReadLine();

        Console.Write("Enter steps taken: ");
        steps[count] = int.Parse(Console.ReadLine());

        count++;
        Console.WriteLine("User added successfully.");
    }

    // Method to update steps (frequent syncing)
    static void UpdateSteps()
    {
        Console.Write("Enter user name to update steps: ");
        string updateName = Console.ReadLine();
        bool found = false;

        for (int i=0;i<count;i++)
        {
            if (names[i] == updateName)
            {
                Console.Write("Enter new step count: ");
                steps[i] = int.Parse(Console.ReadLine());
                found = true;
                Console.WriteLine("Steps updated.");
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("User not found.");
        }
    }

    // Method to sort users using Bubble Sort
    static void SortLeaderboard()
    {
        for (int i=0;i<count-1;i++)
        {
            for (int j=0;j<count-i-1;j++)
            {
                if (steps[j] < steps[j + 1])
                {
                    // Swap steps
                    int tempSteps = steps[j];
                    steps[j] = steps[j + 1];
                    steps[j + 1] = tempSteps;

                    // Swap names accordingly
                    string tempName = names[j];
                    names[j] = names[j + 1];
                    names[j + 1] = tempName;
                }
            }
        }
    }

    // Method to display leaderboard
    static void DisplayLeaderboard()
    {
        Console.WriteLine("--- Leaderboard ---");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine((i + 1) + ". " + names[i] + " - " + steps[i] + " steps");
        }
    }
}
