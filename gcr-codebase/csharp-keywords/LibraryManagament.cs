using System;

class Book{
	
    // static variable
    public static string LibraryName = "City Library";

    // readonly variable
    public readonly string ISBN;

    // instance variables
    public string Title;
    public string Author;

    // constructor using this
    public Book(string isbn, string title, string author){
		
        this.ISBN = isbn;
        this.Title = title;
        this.Author = author;
    }

    // static method
    public static void DisplayLibraryName(){
		
        Console.WriteLine("Library Name: " + LibraryName);
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
    }
}

class Program{
	
    static void Main(){
		
        Book book1 = new Book("ISBN101", "C# Basics", "John");

        // is operator
        if (book1 is Book){
			
            Book.DisplayLibraryName();
            book1.DisplayDetails();
        }
    }
}
