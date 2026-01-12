
/*

Story 1: Metal Factory Pipe Cutting
Context: Maximize revenue from cutting metal rods of different sizes and values.
Scenario A: Given a rod of length 8 and price chart for different lengths, find best
cuts.
Scenario B: Add a custom-length order and check impact on revenue.
Scenario C: Visualize revenue if cut strategy is not optimized.

*/


using System;

// ABSTRACTION 
abstract class RodFactory
{
    protected int rodLength;
    protected int[] prices;

    public abstract void OptimizedCut();
    public abstract void NonOptimizedCut();
}

// INHERITANCE 
class MetalRodCutting : RodFactory
{
    // Constructor to take input
    public MetalRodCutting()
    {
        Console.Write("Enter rod length: ");
        rodLength = Convert.ToInt32(Console.ReadLine());

        prices = new int[rodLength + 1];
        prices[0] = 0;

        Console.WriteLine("Enter prices for each length:");
        for (int i = 1; i <= rodLength; i++)
        {
            Console.Write("Price for length " + i + ": ");
            prices[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // POLYMORPHISM 
    public override void OptimizedCut()
    {
        int[] dp = new int[rodLength + 1];

        for (int i = 1; i <= rodLength; i++)
        {
            int max = 0;

            for (int j = 1; j <= i; j++)
            {
                max = Math.Max(max, prices[j] + dp[i - j]);
            }

            dp[i] = max;
        }

        Console.WriteLine("Optimized Revenue: " + dp[rodLength]);
    }

    // POLYMORPHISM 
    public override void NonOptimizedCut()
    {
        Console.WriteLine("Non-Optimized Revenue: " + prices[rodLength]);
    }

    // ENCAPSULATION 
    public void AddCustomPrice()
    {
        Console.Write("Enter length to update: ");
        int length = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new price: ");
        int price = Convert.ToInt32(Console.ReadLine());

        prices[length] = price;
        Console.WriteLine("Price updated successfully!");
    }
}

// MENU DRIVEN
class Program
{
    static void Main()
    {
        MetalRodCutting rod = new MetalRodCutting();
        int choice;

        do
        {
            Console.WriteLine("\n--- Metal Factory Pipe Cutting ---");
            Console.WriteLine("1. Scenario A - Optimized Cutting");
            Console.WriteLine("2. Scenario B - Add Custom Length Price");
            Console.WriteLine("3. Scenario C - Non Optimized Cutting");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    rod.OptimizedCut();
                    break;

                case 2:
                    rod.AddCustomPrice();
                    rod.OptimizedCut();
                    break;

                case 3:
                    rod.NonOptimizedCut();
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
