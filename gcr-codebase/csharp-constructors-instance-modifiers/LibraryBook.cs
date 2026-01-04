using System;

class LibraryBook {
	
    string title;
    string author;
    double price;
    bool available;

    public LibraryBook(string t, string a, double p){
		
        title = t;
        author = a;
        price = p;
        available = true;
    }

    public void BorrowBook(){
		
        if(available){
			
            available = false;
            Console.WriteLine("Book borrowed successfully.");
        }
        else{
			
            Console.WriteLine("Book not available.");
        }
    }

    public void Display(){
		
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Available: " + available);
    }
}

class Program{
	
    static void Main() {
		
        LibraryBook b = new LibraryBook("C# Guide", "James", 500);
        b.Display();
        b.BorrowBook();
    }
}
