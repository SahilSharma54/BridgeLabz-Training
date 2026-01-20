using System;
using System.Collections.Generic;

// Abstract base class
abstract class WarehouseItem
{
    public string Name { get; set; }
    public abstract void Display();
}

// Electronics item
class Electronics : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Electronics Item: " + Name);
    }
}

// Grocery item
class Grocery : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Grocery Item: " + Name);
    }
}

// Furniture item
class Furniture : WarehouseItem
{
    public override void Display()
    {
        Console.WriteLine("Furniture Item: " + Name);
    }
}

// Generic storage class with constraint
class Storage<T> where T : WarehouseItem
{
    List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        foreach (T item in items)
            item.Display();
    }
}

class Program
{
    static void Main()
    {
        Storage<WarehouseItem> storage = new Storage<WarehouseItem>();
        int choice;

        do
        {
            Console.WriteLine("--- Warehouse Menu ---");
            Console.WriteLine("1. Add Electronics");
            Console.WriteLine("2. Add Grocery");
            Console.WriteLine("3. Add Furniture");
            Console.WriteLine("4. Display Items");
            Console.WriteLine("5. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
					Console.WriteLine("Enter the Item for electronics");
                    storage.AddItem(new Electronics { Name = Console.ReadLine()});
                    break;
                case 2:
					Console.WriteLine("Enter the Item for groceries");
                    storage.AddItem(new Grocery { Name = Console.ReadLine()});
                    break;
                case 3:
					Console.WriteLine("Enter the Item for Furniture");
                    storage.AddItem(new Furniture { Name = Console.ReadLine()});
                    break;
                case 4:
                    storage.DisplayItems();
                    break;
            }
        } while (choice != 5);
    }
}
