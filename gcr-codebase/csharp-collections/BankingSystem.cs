using System;
using System.Collections.Generic;

class BankingSystem
{
    static Dictionary<int, double> accounts = new Dictionary<int, double>();
    static Queue<int> withdrawalQueue = new Queue<int>();

    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("\n--- Banking System ---");
            Console.WriteLine("1. Add Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Queue Withdrawal");
            Console.WriteLine("4. Process Withdrawals");
            Console.WriteLine("5. Display Accounts Sorted by Balance");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: AddAccount(); break;
                case 2: Deposit(); break;
                case 3: QueueWithdrawal(); break;
                case 4: ProcessWithdrawals(); break;
                case 5: DisplaySortedAccounts(); break;
            }

        } while (choice != 6);
    }

    // Add a new account
    static void AddAccount()
    {
        Console.Write("Enter Account Number: ");
        int acc = int.Parse(Console.ReadLine());
        Console.Write("Enter Initial Balance: ");
        double bal = double.Parse(Console.ReadLine());

        if (accounts.ContainsKey(acc))
            Console.WriteLine("Account already exists!");
        else
        {
            accounts[acc] = bal;
            Console.WriteLine("Account added successfully.");
        }
    }

    // Deposit money
    static void Deposit()
    {
        Console.Write("Enter Account Number: ");
        int acc = int.Parse(Console.ReadLine());
        Console.Write("Enter Deposit Amount: ");
        double bal = double.Parse(Console.ReadLine());

        if (accounts.ContainsKey(acc))
        {
            accounts[acc] += bal;
            Console.WriteLine("Deposit successful.");
        }
        else
            Console.WriteLine("Account not found!");
    }

    // Add account to withdrawal queue
    static void QueueWithdrawal()
    {
        Console.Write("Enter Account Number to Withdraw: ");
        int acc = int.Parse(Console.ReadLine());

        if (accounts.ContainsKey(acc))
        {
            withdrawalQueue.Enqueue(acc);
            Console.WriteLine("Account added to withdrawal queue.");
        }
        else
            Console.WriteLine("Account not found!");
    }

    // Process withdrawals in FIFO order
    static void ProcessWithdrawals()
    {
        Console.WriteLine("Processing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            int acc = withdrawalQueue.Dequeue();
            if (accounts.ContainsKey(acc))
            {
                if (accounts[acc] >= 100) // Fixed withdrawal amount
                {
                    accounts[acc] -= 100;
                    Console.WriteLine("Withdrawal of 100 processed for Account " + acc);
                }
                else
                    Console.WriteLine("Insufficient balance for Account " + acc);
            }
            else
                Console.WriteLine("Account " + acc + " does not exist.");
        }
    }

    // Display all accounts sorted by balance (ascending)
    static void DisplaySortedAccounts()
    {
        Console.WriteLine("Accounts Sorted by Balance:");

        // Convert dictionary to list
        List<KeyValuePair<int, double>> accountList = new List<KeyValuePair<int, double>>(accounts);

        // Bubble sort by balance
        for (int i = 0; i < accountList.Count - 1; i++)
        {
            for (int j = 0; j < accountList.Count - i - 1; j++)
            {
                if (accountList[j].Value > accountList[j + 1].Value)
                {
                    var temp = accountList[j];
                    accountList[j] = accountList[j + 1];
                    accountList[j + 1] = temp;
                }
            }
        }

        foreach (var pair in accountList)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}
