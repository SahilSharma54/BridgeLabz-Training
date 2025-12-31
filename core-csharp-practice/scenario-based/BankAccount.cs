/*

Bank Account Manager
1. Scenario: A banking app needs to perform operations like deposit, withdraw, and check balance for a user.
● Problem: Design a BankAccount class with:
● Fields/Properties: AccountNumber, Balance.
● Methods: Deposit(double), Withdraw(double), CheckBalance().
● Include logic to prevent overdraft.


*/


using System;

class BankAccount{
	
    // Fields
    public string AccountNumber;
    public double Balance;

    // Constructor
    public BankAccount(string accountNumber, double balance){
		
        AccountNumber = accountNumber;
        Balance = balance;
    }

    // Deposit method
    public void Deposit(double amount){
		
        if (amount > 0){
			
            Balance += amount;
            Console.WriteLine("Amount deposited successfully.");
        }
        else{
			
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    // Withdraw method
    public void Withdraw(double amount){
		
        if (amount > 0 && amount <= Balance){
			
            Balance -= amount;
            Console.WriteLine("Amount withdrawn successfully.");
        }
        else{
			
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    // Check balance method
    public void CheckBalance(){
		
        Console.WriteLine("Current Balance: " + Balance);
    }
}

// Bank Manager class
class BankManager{
	
    public void DepositMoney(BankAccount account, double amount){
		
        account.Deposit(amount);
    }

    public void WithdrawMoney(BankAccount account, double amount){
		
        account.Withdraw(amount);
    }

    public void ShowBalance(BankAccount account){
		
        account.CheckBalance();
    }
}

// Customer class
class Customer{
	
    public void Start(BankManager manager, BankAccount account){
		
        int choice;

        do{
			
            Console.WriteLine("\n--- Bank Menu ---");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1){
				
                Console.Write("Enter amount to deposit: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                manager.DepositMoney(account, amount);
            }
            else if (choice == 2){
				
                Console.Write("Enter amount to withdraw: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                manager.WithdrawMoney(account, amount);
            }
            else if (choice == 3){
				
                manager.ShowBalance(account);
            }
            else if (choice == 4){
				
                Console.WriteLine("Thank you for using the bank system.");
            }
            else{
				
                Console.WriteLine("Invalid choice.");
            }

        } while (choice != 4);
    }
}

class Program {
	
    static void Main(string[] args){
		
        Console.Write("Enter Account Number: ");
        string accountNumber = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());

        BankAccount account = new BankAccount(accountNumber, balance);
        BankManager manager = new BankManager();
        Customer customer = new Customer();

        customer.Start(manager, account);
    }
}
