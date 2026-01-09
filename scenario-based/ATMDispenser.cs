using System;

class ATMDispenser
{
    static void Main(string[] args)
    {
        // Scenario 1: With ₹500
        int[] denomination = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

        // Scenario 2: Without ₹500
        int[] denomination2 = { 200, 100, 50, 20, 10, 5, 2, 1 };

        Console.WriteLine("Which Scenario you want to perform? Type A, B, or C:");
        Console.WriteLine("A: Optimal combo using 500");
        Console.WriteLine("B: Optimal combo without using 500");
        Console.WriteLine("C: Fallback combo if exact change isn’t possible");

        string choice = Console.ReadLine().ToUpper();

        Console.Write("Enter the amount to dispense: ");
        int amount = int.Parse(Console.ReadLine());

        int dispensed = 0;
        int totalNotes = 0;

        int[] selectedDenomination;

        switch (choice)
        {
            case "A":
                selectedDenomination = denomination;
                break;
            case "B":
                selectedDenomination = denomination2;
                break;
            case "C":
                selectedDenomination = denomination; //try all, fallback if needed
                break;
            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Console.WriteLine("\nDispensing Notes:");

        // Loop through denominations
        for (int i = 0; i < selectedDenomination.Length; i++)
        {
            while (selectedDenomination[i] <= (amount - dispensed))
            {
                dispensed += selectedDenomination[i];
                totalNotes++;
                Console.WriteLine("Dispensed: " + selectedDenomination[i]);
            }

            if (dispensed == amount)
                break;
        }

        if (dispensed < amount)
        {
            Console.WriteLine("Cannot dispense exact amount with available denominations.");
            Console.WriteLine("Dispensed amount: " + dispensed);
        }
        else
        {
            Console.WriteLine("Total amount dispensed: "+dispensed);
            Console.WriteLine("Total notes dispensed: " + totalNotes);
        }
    }
}
