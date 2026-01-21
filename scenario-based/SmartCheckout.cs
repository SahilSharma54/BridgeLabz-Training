

/*

SmartCheckout – Supermarket Billing Queue (Queue + HashMap)
Story: At a supermarket, each checkout counter maintains a Queue of customers. Each
customer has a list of items, and a HashMap is used to fetch price and stock quickly.
 Requirements:
● Add/remove customers from the queue.
● Fetch item prices from map.
● Update stock on purchase.

*/

using System;
using System.Collections.Generic;


// Interface hides checkout operations
interface ICheckout
{
    void AddCustomer(string name);
    void ProcessCustomer();
}


// Base class stores items, price and stock
class Store
{
    protected Dictionary<string, int> priceMap = new Dictionary<string, int>();
    protected Dictionary<string, int> stockMap = new Dictionary<string, int>();

    // Initialize items
    public Store()
    {
        priceMap["Milk"] = 50;
        priceMap["Bread"] = 30;
        priceMap["Rice"] = 60;

        stockMap["Milk"] = 20;
        stockMap["Bread"] = 15;
        stockMap["Rice"] = 25;
    }

    // Display available items
    public void DisplayItems()
    {
        Console.WriteLine("\nItem\tPrice\tStock");
        foreach (var item in priceMap)
        {
            Console.WriteLine(item.Key + "\t" + item.Value + "\t" + stockMap[item.Key]);
        }
    }
}



// Derived class handles billing queue
class SmartCheckout : Store, ICheckout
{
    Queue<string> customerQueue = new Queue<string>();

    // Add customer to queue
    public void AddCustomer(string name)
    {
        customerQueue.Enqueue(name);
        Console.WriteLine(name + " added to checkout queue.");
    }

    // Process customer billing
    public void ProcessCustomer()
    {
        if (customerQueue.Count == 0)
        {
            Console.WriteLine("No customers in queue.");
            return;
        }

        string customer = customerQueue.Dequeue();
        Console.WriteLine("\nProcessing customer: " + customer);

        int totalBill = 0;
        string itemName;
        int quantity;

        DisplayItems();

        while (true)
        {
            Console.Write("\nEnter item name (or 'done'): ");
            itemName = Console.ReadLine();

            if (itemName.ToLower() == "done")
                break;

            if (!priceMap.ContainsKey(itemName))
            {
                Console.WriteLine("Item not found!");
                continue;
            }

            Console.Write("Enter quantity: ");
            quantity = int.Parse(Console.ReadLine());

            if (stockMap[itemName] < quantity)
            {
                Console.WriteLine("Insufficient stock!");
                continue;
            }

            // Calculate bill and update stock
            totalBill += priceMap[itemName] * quantity;
            stockMap[itemName] -= quantity;
        }

        Console.WriteLine("Total Bill for " + customer + " = " + totalBill);
    }
}


// Main application
class SmartCheckoutApp
{
    static void Main()
    {
        SmartCheckout checkout = new SmartCheckout();
        int choice;

        do
        {
            Console.WriteLine("\n===== SmartCheckout – Supermarket Billing =====");
            Console.WriteLine("1. Add Customer to Queue");
            Console.WriteLine("2. Process Customer Billing");
            Console.WriteLine("3. View Items & Stock");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter customer name: ");
                    checkout.AddCustomer(Console.ReadLine());
                    break;

                case 2:
                    checkout.ProcessCustomer();
                    break;

                case 3:
                    checkout.DisplayItems();
                    break;

                case 4:
                    Console.WriteLine("System Closed.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }
}
