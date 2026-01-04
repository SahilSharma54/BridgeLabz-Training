using System;

class Product{
	
    // static variable
    public static double Discount = 10;

    // readonly variable
    public readonly int ProductID;

    // instance variables
    public string ProductName;
    public double Price;
    public int Quantity;

    // constructor using 'this'
    public Product(int id, string name, double price, int qty){
		
        this.ProductID = id;
        this.ProductName = name;
        this.Price = price;
        this.Quantity = qty;
    }

    // static method
    public static void UpdateDiscount(double newDiscount){
		
        Discount = newDiscount;
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("Product ID: " + ProductID);
        Console.WriteLine("Product Name: " + ProductName);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine("Discount: " + Discount + "%");
    }
}

class Program{
	
    static void Main(){
		
        Product p1 = new Product(201, "Laptop", 50000, 2);

        // is operator
        if (p1 is Product){
			
            p1.DisplayDetails();
        }

        Product.UpdateDiscount(15);
        Console.WriteLine("Updated Discount: " + Product.Discount + "%");
    }
}
