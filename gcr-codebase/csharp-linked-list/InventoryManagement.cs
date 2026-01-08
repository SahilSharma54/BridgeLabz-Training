using System;

class ItemNode
{
    public int id;
    public string name;
    public int quantity;
    public double price;
    public ItemNode next;
}

class InventoryList
{
    ItemNode head;

    public void AddItem()
    {
        ItemNode n = new ItemNode();

        Console.Write("Item ID: ");
        n.id = int.Parse(Console.ReadLine());

        Console.Write("Item Name: ");
        n.name = Console.ReadLine();

        Console.Write("Quantity: ");
        n.quantity = int.Parse(Console.ReadLine());

        Console.Write("Price: ");
        n.price = double.Parse(Console.ReadLine());

        n.next = head;
        head = n;

        Console.WriteLine("Item Added");
    }

    public void RemoveItem()
    {
        Console.Write("Enter Item ID to Remove: ");
        int id = int.Parse(Console.ReadLine());

        ItemNode temp = head, prev = null;

        while (temp != null && temp.id != id)
        {
            prev = temp;
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine("Item Not Found");
            return;
        }

        if (prev == null)
            head = temp.next;
        else
            prev.next = temp.next;

        Console.WriteLine("Item Removed");
    }

    public void UpdateQuantity()
    {
        Console.Write("Item ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("New Quantity: ");
        int qty = int.Parse(Console.ReadLine());

        ItemNode temp = head;

        while (temp != null)
        {
            if (temp.id == id)
            {
                temp.quantity = qty;
                Console.WriteLine("Quantity Updated");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Item Not Found");
    }

    public void SearchItem()
    {
        Console.Write("Enter Item ID or Name: ");
        string input = Console.ReadLine();

        ItemNode temp = head;

        while (temp != null)
        {
            if (temp.id.ToString() == input || temp.name == input)
            {
                Console.WriteLine(temp.name + " Qty: " + temp.quantity);
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Item Not Found");
    }

    public void TotalValue()
    {
        ItemNode temp = head;
        double total = 0;

        while (temp != null)
        {
            total += temp.price * temp.quantity;
            temp = temp.next;
        }

        Console.WriteLine("Total Inventory Value: " + total);
    }

    public void Display()
    {
        ItemNode temp = head;

        while (temp != null)
        {
            Console.WriteLine(
                temp.id + " " +
                temp.name + " Qty:" +
                temp.quantity + " Price:" +
                temp.price);
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        InventoryList list = new InventoryList();
        int ch;

        do
        {
            Console.WriteLine("\n--- Inventory Menu ---");
            Console.WriteLine("1.Add Item");
            Console.WriteLine("2.Remove Item");
            Console.WriteLine("3.Update Quantity");
            Console.WriteLine("4.Search Item");
            Console.WriteLine("5.Total Value");
            Console.WriteLine("6.Display");
            Console.WriteLine("7.Exit");
            Console.Write("Choice: ");

            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: list.AddItem(); break;
                case 2: list.RemoveItem(); break;
                case 3: list.UpdateQuantity(); break;
                case 4: list.SearchItem(); break;
                case 5: list.TotalValue(); break;
                case 6: list.Display(); break;
            }

        } while (ch != 7);
    }
}
