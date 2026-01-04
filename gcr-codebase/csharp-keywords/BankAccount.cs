using System;

class BankAccount{
	
    // static variable (shared)
    public static string bankName = "ABC Bank";

    // readonly variable
    public readonly int accountNumber;

    // instance variable
    public string accountHolderName;

    // static variable to count accounts
    static int totalAccounts = 0;

    // constructor using 'this'
    public BankAccount(int accountNumber, string accountHolderName){
		
        this.accountNumber = accountNumber;
        this.accountHolderName = accountHolderName;
        totalAccounts++;
    }

    // static method
    public static void GetTotalAccounts(){
		
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder: " + accountHolderName);
    }
}

class Program{
	
    static void Main(){
		
        BankAccount acc1 = new BankAccount(101, "Rahul");

        // is operator check
        if (acc1 is BankAccount){
			
            acc1.DisplayDetails();
        }

        BankAccount.GetTotalAccounts();
    }
}
