using System;

// Custom exception for insufficient balance
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message)
    {
    }
}

class BankAccount
{
    double balance = 5000; // Initial balance

    // Withdraw method
    public void Withdraw(double amount)
    {
        // Check for invalid amount
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }

        // Check for insufficient balance
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }

        // Deduct amount
        balance -= amount;
        Console.WriteLine("Withdrawal successful");
        Console.WriteLine("Remaining balance: " + balance);
    }
}

class BankTransaction
{
    static void Main()
    {
        BankAccount account = new BankAccount();

        try
        {
            // Take input from user
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            // Perform withdrawal
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}
