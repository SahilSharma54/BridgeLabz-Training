using System;

class BankAccount{
	
    // Public variable – can be accessed anywhere
    public int accountNumber;

    // Protected variable – accessible in derived classes
    protected string accountHolder;

    // Private variable – accessible only inside this class
    private double balance;

    // Constructor to initialize account details
    public BankAccount(int accNo, string holder, double bal){
		
        accountNumber = accNo;
        accountHolder = holder;
        balance = bal;
    }

    // Method to get the current balance
    public double GetBalance(){
		
        return balance;
    }

    // Method to update the account balance
    public void UpdateBalance(double amount){
		
        balance = amount;
    }
}

// Child class inheriting from BankAccount
class SavingsAccount : BankAccount {
	
    // Constructor calling base class constructor
    public SavingsAccount(int accNo, string holder, double bal)
        : base(accNo, holder, bal)
    {
    }

    // Method to display account details
    public void DisplayDetails(){
		
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolder);
        Console.WriteLine("Balance: " + GetBalance());
    }
}

class Program {
	
    static void Main(){
		
        // Creating object of SavingsAccount
        SavingsAccount s = new SavingsAccount(101, "Rahul", 5000);

        // Displaying account details
        s.DisplayDetails();

        // Updating the account balance
        s.UpdateBalance(8000);

        // Displaying updated balance
        Console.WriteLine("Updated Balance: " + s.GetBalance());
    }
}
