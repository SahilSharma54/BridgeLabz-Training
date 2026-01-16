/*


BookShelf – Library Organiz Story: In a library system, books are arranged based on genre and author. 
A HashMap maps genre → list of books (LinkedList). 
Each list is dynamically updated when books are borrowed or returned.

Requirements:
● Maintain genre-wise catalog.
● Efficient insert, delete using LinkedList.


*/

using System;

// ABSTRACTION
interface ILibrary
{
    void AddBook();
    void BorrowBook();
    void DisplayBooks();
}

// BASE CLASS
class Book
{
    protected string title;
    protected string author;

    // Constructor
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    // Polymorphism
    public virtual void Display()
    {
        Console.WriteLine(title + " by " + author);
    }

    public string GetTitle()
    {
        return title;
    }
}

// INHERITANCE
class LibraryBook : Book
{
    public LibraryBook(string title, string author)
        : base(title, author)
    {
    }

    // POLYMORPHISM
    public override void Display()
    {
        Console.WriteLine("Book: " + title + " | Author: " + author);
    }
}

// LINKED LIST NODE
class BookNode
{
    public LibraryBook book;
    public BookNode next;

    public BookNode(LibraryBook book)
    {
        this.book = book;
        next = null;
    }
}

// CUSTOM LINKED LIST
class BookLinkedList
{
    private BookNode head; // Encapsulation

    // Add book
    public void AddBook(LibraryBook book)
    {
        BookNode newNode = new BookNode(book);

        if (head == null)
        {
            head = newNode;
            return;
        }

        BookNode temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }

        temp.next = newNode;
    }

    // Remove book
    public void RemoveBook(string title)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        if (head.book.GetTitle() == title)
        {
            head = head.next;
            Console.WriteLine("Book borrowed successfully.");
            return;
        }

        BookNode current = head;
        while (current.next != null)
        {
            if (current.next.book.GetTitle() == title)
            {
                current.next = current.next.next;
                Console.WriteLine("Book borrowed successfully.");
                return;
            }
            current = current.next;
        }

        Console.WriteLine("Book not found.");
    }

    // Display books
    public void DisplayBooks()
    {
        if (head == null)
        {
            Console.WriteLine("No books available.");
            return;
        }

        BookNode temp = head;
        while (temp != null)
        {
            temp.book.Display(); // Polymorphism
            temp = temp.next;
        }
    }
}

// LIBRARY CLASS
class Library : ILibrary
{
    private BookLinkedList bookList = new BookLinkedList();

    public void AddBook()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        LibraryBook book = new LibraryBook(title, author);
        bookList.AddBook(book);

        Console.WriteLine("Book added successfully.");
    }

    public void BorrowBook()
    {
        Console.Write("Enter Book Title to Borrow: ");
        string title = Console.ReadLine();

        bookList.RemoveBook(title);
    }

    public void DisplayBooks()
    {
        bookList.DisplayBooks();
    }
}

// MENU DRIVEN MAIN
class Program
{
    static void Main(string[] args)
    {
        ILibrary library = new Library(); // Abstraction
        int choice;

        do
        {
            Console.WriteLine("--- Library Menu ---");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Display Books");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    library.AddBook();
                    break;

                case 2:
                    library.BorrowBook();
                    break;

                case 3:
                    library.DisplayBooks();
                    break;

                case 4:
                    Console.WriteLine("Exiting The Book Shelf ...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}


