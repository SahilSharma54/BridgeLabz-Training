using System;

class Book{
	
    // Public variable accessible everywhere
    public string ISBN;

    // Protected variable accessible in derived classes
    protected string title;

    // Private variable accessible only inside this class
    private string author;

    // Constructor to initialize book details
    public Book(string isbn, string t, string a){
		
        ISBN = isbn;
        title = t;
        author = a;
    }

    // Method to update author name
    public void SetAuthor(string a){
		
        author = a;
    }

    // Method to get author name
    public string GetAuthor(){
		
        return author;
    }
}

// Derived class inheriting from Book
class EBook : Book {
	
    // Constructor calling base class constructor
    public EBook(string isbn, string t, string a) : base(isbn, t, a) { }

    // Method to display book details
    public void Display(){
		
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + GetAuthor());
    }
}

class Program {
	
    static void Main(){
		
        // Creating an object of EBook
        EBook e = new EBook("ISBN123", "C# Basics", "John");

        // Displaying ebook details
        e.Display();
    }
}
