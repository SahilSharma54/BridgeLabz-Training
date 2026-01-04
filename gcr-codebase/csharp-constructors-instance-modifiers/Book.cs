using System;

class Book{
	
    string title;
    string author;
    double price;

    // Default constructor
    public Book(){
		
        title = "Unknown";
        author = "Unknown";
        price = 0;
    }

    // Parameterized constructor
    public Book(string t, string a, double p){
		
        title = t;
        author = a;
        price = p;
    }

    public void Display(){
		
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Program{
	
    static void Main(){
		
        Book b1 = new Book();
        b1.Display();

        Book b2 = new Book("C# Basics", "John", 450);
        b2.Display();
    }
}
