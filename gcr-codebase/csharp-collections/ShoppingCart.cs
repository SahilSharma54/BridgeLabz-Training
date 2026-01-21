using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    static void Main()
    {
        Dictionary<string, double> cart = new Dictionary<string, double>();
        LinkedList<string> order = new LinkedList<string>(); // preserve order

        int choice;
        do
        {
            Console.WriteLine("\n--- Shopping Cart ---");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products in Order");
            Console.WriteLine("3. Display Products Sorted by Price");
            Console.WriteLine("4. Exit");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Product Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter Price: ");
                    double price = double.Parse(Console.ReadLine());

                    cart[name] = price;
                    order.AddLast(name);
                    break;

                case 2:
                    Console.WriteLine("\nProducts in Insertion Order:");
                    foreach (var p in order)
                        Console.WriteLine(p + " : " + cart[p]);
                    break;

                case 3:
                    Console.WriteLine("\nProducts Sorted by Price:");
                    foreach (var p in cart.OrderBy(x => x.Value))
                        Console.WriteLine(p.Key + " : " + p.Value);
                    break;
            }
        } while (choice != 4);
    }
}
