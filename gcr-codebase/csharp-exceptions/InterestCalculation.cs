using System;

class InterestCalculation
{
    // Method to calculate interest
    static double CalculateInterest(double amount, double rate, int years)
    {
        // Check for invalid input
        if (amount < 0 || rate < 0)
        {
            // Throw exception to be handled in Main
            throw new ArgumentException("Invalid input: Amount and rate must be positive");
        }

        // Simple Interest formula
        return (amount * rate * years) / 100;
    }

    static void Main()
    {
        try
        {
            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter years: ");
            int years = int.Parse(Console.ReadLine());

            // Call method
            double interest = CalculateInterest(amount, rate, years);
            Console.WriteLine("Calculated Interest: " + interest);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter valid numeric values");
        }
    }
}
