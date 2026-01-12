
/*

Story 2: Custom Furniture Manufacturing
Context: A carpenter cuts wooden rods for furniture with pricing based on size.
Scenario A: Determine best cut to maximize earnings for 12ft rod.
Scenario B: If customer adds a fixed waste constraint, modify logic.
Scenario C: Suggest cuts for maximizing both revenue and minimal waste.

*/

using System;

// ABSTRACTION 
abstract class CarpenterShop
{
    protected int rodLength;
    protected int[] prices;

    public abstract void MaxRevenueCut();
    public abstract void RevenueWithWasteConstraint(int allowedWaste);
    public abstract void RevenueWithMinWaste();
}

// INHERITANCE 
class FurnitureCutting : CarpenterShop
{
    // Constructor – takes user input
    public FurnitureCutting()
    {
        Console.Write("Enter wooden rod length (in feet): ");
        rodLength = Convert.ToInt32(Console.ReadLine());

        prices = new int[rodLength + 1];
        prices[0] = 0;

        Console.WriteLine("Enter price for each length:");
        for (int i = 1; i <= rodLength; i++)
        {
            Console.Write("Price for " + i + " ft: ");
            prices[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // SCENARIO A 
    public override void MaxRevenueCut()
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

        Console.WriteLine("Maximum Revenue: " + dp[rodLength]);
    }

    // SCENARIO B 
    public override void RevenueWithWasteConstraint(int allowedWaste)
    {
        int usableLength = rodLength - allowedWaste;

        if (usableLength <= 0)
        {
            Console.WriteLine("Waste too high. No usable wood.");
            return;
        }

        int[] dp = new int[usableLength + 1];

        for (int i = 1; i <= usableLength; i++)
        {
            int max = 0;
            for (int j = 1; j <= i; j++)
            {
                max = Math.Max(max, prices[j] + dp[i - j]);
            }
            dp[i] = max;
        }

        Console.WriteLine("Revenue with waste constraint: " + dp[usableLength]);
    }

    // SCENARIO C
    public override void RevenueWithMinWaste()
    {
        int bestRevenue = 0;
        int minWaste = rodLength;

        for (int used = rodLength; used >= 1; used--)
        {
            int[] dp = new int[used + 1];

            for (int i = 1; i <= used; i++)
            {
                int max = 0;
                for (int j = 1; j <= i; j++)
                {
                    max = Math.Max(max, prices[j] + dp[i - j]);
                }
                dp[i] = max;
            }

            int waste = rodLength - used;

            if (dp[used] > bestRevenue || 
               (dp[used] == bestRevenue && waste < minWaste))
            {
                bestRevenue = dp[used];
                minWaste = waste;
            }
        }

        Console.WriteLine("Best Revenue: " + bestRevenue);
        Console.WriteLine("Minimum Waste: " + minWaste + " ft");
    }
}

// MENU DRIVEN
class Program
{
    static void Main()
    {
        FurnitureCutting shop = new FurnitureCutting();
        int choice;

        do
        {
            Console.WriteLine("\n--- Custom Furniture Manufacturing ---");
            Console.WriteLine("1. Scenario A - Maximize Revenue");
            Console.WriteLine("2. Scenario B - Revenue with Waste Constraint");
            Console.WriteLine("3. Scenario C - Max Revenue with Min Waste");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    shop.MaxRevenueCut();
                    break;

                case 2:
                    Console.Write("Enter allowed waste (ft): ");
                    int waste = Convert.ToInt32(Console.ReadLine());
                    shop.RevenueWithWasteConstraint(waste);
                    break;

                case 3:
                    shop.RevenueWithMinWaste();
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
