using System;

// Base category class
abstract class Category { }

// Different product categories
class BookCategory : Category { }
class ClothingCategory : Category { }

// Generic Product class
class Product<T> where T : Category
{
    public string Name;
    public double Price;

    // Display product details
    public void Display()
    {
        Console.WriteLine("Product: "+Name+" Price: "+Price);
    }
}

class Marketplace
{
    // Generic method to apply discount
    public static void ApplyDiscount<T>(Product<T> product, double percent) where T : Category
    {
        product.Price -= product.Price * percent / 100;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Select Product Category:");
        Console.WriteLine("1. Book");
        Console.WriteLine("2. Clothing");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter product price: ");
        double price = double.Parse(Console.ReadLine());

        Console.Write("Enter discount percentage: ");
        double discount = double.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Product<BookCategory> product = new Product<BookCategory>
            {
                Name = name,
                Price = price
            };
            Marketplace.ApplyDiscount(product, discount);
            product.Display();
        }
        else
        {
            Product<ClothingCategory> product = new Product<ClothingCategory>
            {
                Name = name,
                Price = price
            };
            Marketplace.ApplyDiscount(product, discount);
            product.Display();
        }
    }
}
