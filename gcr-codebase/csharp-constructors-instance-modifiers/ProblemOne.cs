using System;

class Product{
	
    string productName;
    double price;

    static int totalProducts = 0;

    public Product(string name, double p){
		
        productName = name;
        price = p;
        totalProducts++;
    }

    public void DisplayProductDetails(){
		
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Price: " + price);
    }

    public static void DisplayTotalProducts(){
		
        Console.WriteLine("Total Products: " + totalProducts);
    }
}

class Program{
	
    static void Main(){
		
        Product p1 = new Product("Laptop", 50000);
        Product p2 = new Product("Mobile", 20000);

        p1.DisplayProductDetails();
        p2.DisplayProductDetails();

        Product.DisplayTotalProducts();
    }
}
