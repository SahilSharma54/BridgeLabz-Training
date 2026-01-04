using System;

class Book{
	
    string title;
    string author;
    double price;

    public void GetDetails(){
		
        Console.Write("Enter Book Title: ");
        title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        author = Console.ReadLine();

        Console.Write("Enter Price: ");
        price = double.Parse(Console.ReadLine());
    }

    public void DisplayDetails(){
		
        Console.WriteLine("\nBook Details:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}

class Program {
	
    static void Main(string[] args){
		
        Book book = new Book();
        book.GetDetails();
        book.DisplayDetails();
    }
}
