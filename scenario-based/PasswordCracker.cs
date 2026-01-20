/*

Backtracking
Story 1: Password Cracker Simulator
Context: Try all possible combinations to unlock a vault.
Scenario A: Generate all strings of length n.
Scenario B: Stop if password is matched.
Scenario C: Visualize time-space complexity.

*/

using System;

class PasswordCracker
{
    // Character set to try (can be expanded)
    static char[] charset = { 'a', 'b', 'c', '1', '2' };

    static bool passwordFound = false;
    static string targetPassword = "";
    static int attempts = 0;

    // Backtracking function to generate all combinations
    static void CrackPassword(char[] current, int index, int length)
    {
        // Stop recursion if password is already found
        if (passwordFound)
            return;

        // If current string length is completed
        if (index == length)
        {
            string guess = new string(current);
            attempts++;

            Console.WriteLine("Trying: " + guess);

            // Scenario B: Stop if password matches
            if (guess.Equals(targetPassword))
            {
                Console.WriteLine("PASSWORD FOUND: " + guess);
                Console.WriteLine("Attempts taken: " + attempts);
                passwordFound = true;
            }
            return;
        }

        // Try each character (Backtracking)
        for (int i = 0; i < charset.Length; i++)
        {
            current[index] = charset[i];   // choose
            CrackPassword(current, index + 1, length); // explore
            // un-choose happens automatically (backtracking)
        }
    }

    // Function to visualize time & space complexity
    static void VisualizeComplexity(int length)
    {
        int k = charset.Length;
		
		Console.WriteLine();

        Console.WriteLine("--- Complexity Visualization ---");
        Console.WriteLine("Character set size (k): " + k);
        Console.WriteLine("Password length (n): " + length);
		
		Console.WriteLine();
		
        Console.WriteLine("Time Complexity:");
        Console.WriteLine("O(k^n) = O(" + k + "^" + length + ")");
        Console.WriteLine("Total combinations tried = " + Math.Pow(k, length));
		
		Console.WriteLine();
		
        Console.WriteLine("Space Complexity:");
        Console.WriteLine("O(n) due to recursion stack");
		
		Console.WriteLine();
		
        Console.WriteLine("Recursion Tree (Example):");
        Console.WriteLine("Level 0 -> "+" ");
        Console.WriteLine("Level 1 -> a  b  c  1  2");
        Console.WriteLine("Level 2 -> aa ab ac a1 a2 ...");
    }

    static void Main()
    {
        int choice;
        int length = 0;

        do
        {
            Console.WriteLine("--- PASSWORD CRACKER MENU ---");
            Console.WriteLine("1. Set Password & Length");
            Console.WriteLine("2. Start Password Cracking");
            Console.WriteLine("3. Visualize Time & Space Complexity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter password length: ");
                    length = int.Parse(Console.ReadLine());

                    Console.Write("Enter target password: ");
                    targetPassword = Console.ReadLine();

                    passwordFound = false;
                    attempts = 0;
                    break;

                case 2:
                    if (length == 0 || targetPassword == "")
                    {
                        Console.WriteLine("Please set password and length first.");
                        break;
                    }

                    Console.WriteLine("Starting Password Cracking...\n");
                    char[] current = new char[length];
                    CrackPassword(current, 0, length);

                    if (!passwordFound)
                        Console.WriteLine("Password not found.");

                    break;

                case 3:
                    if (length == 0)
                    {
                        Console.WriteLine("Set password length first.");
                        break;
                    }
                    VisualizeComplexity(length);
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }
}
