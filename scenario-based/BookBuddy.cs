/*

"BookBuddy – Digital Bookshelf App"
Story: Users maintain a personal digital bookshelf by adding, updating, and sorting their favorite
books by title and author.
Requirements:
● Use an Arrays to store book titles in "Title - Author" format.
● Methods:
○ addBook(String title, String author)
○ sortBooksAlphabetically()
○ searchByAuthor(String author)
● Use String.split() to separate title and author.

*/


using System;


interface IBookUtility
{
    void AddBook(string title, string author);
    void SortBooksAlphabetically();
    void SearchByAuthor(string author);
}


class VarBookEncapsule
{
    private string[] books; 

    public string[] Books
    {
        get { return books; }
        set { books = value; }
    }
}


class BookUtilityImplement : IBookUtility
{
    VarBookEncapsule ve = new VarBookEncapsule();

    public void AddBook(string title, string author)
    {
        Console.Write("Enter number of books to add: ");
        int size = int.Parse(Console.ReadLine());

        string[] bookList = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter book title: ");
            string t = Console.ReadLine();

            Console.Write("Enter book author: ");
            string a = Console.ReadLine();

            bookList[i] = t + " - " + a;  
        }

        ve.Books = bookList;
        Console.WriteLine("Books added successfully!");
    }

    public void SortBooksAlphabetically()
    {
        if (ve.Books == null)
        {
            Console.WriteLine("No books to sort.");
            return;
        }

        Array.Sort(ve.Books);  
        Console.WriteLine("Books sorted alphabetically:");
        foreach (string b in ve.Books)
        {
            Console.WriteLine(b);
        }
    }

    public void SearchByAuthor(string author)
    {
        if (ve.Books == null)
        {
            Console.WriteLine("No books to search.");
            return;
        }

        bool found = false;
        foreach (string b in ve.Books)
        {
            string[] parts = b.Split('-'); 
			
			string bookAuthor = parts[1].Trim();
			
            if (bookAuthor.Contains(author))
            {
            Console.WriteLine("Found: " + b);
            found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No books found by this author.");
        }
    }
}


class Menu
{
    IBookUtility utility = new BookUtilityImplement();

    public void DisplayMenu()
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.WriteLine("--- BookBuddy – Digital Bookshelf ---");
            Console.WriteLine("1. Add Books");
            Console.WriteLine("2. Sort Books Alphabetically");
            Console.WriteLine("3. Search By Author");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddBook("", "");
                    break;

                case 2:
                    utility.SortBooksAlphabetically();
                    break;

                case 3:
                    Console.Write("Enter author name to search: ");
                    string author = Console.ReadLine();
                    utility.SearchByAuthor(author);
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.DisplayMenu();
    }
}
