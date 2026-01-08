using System;

class BookNode
{
    public int id;
    public string title;
    public string author;
    public string genre;
    public bool available;
    public BookNode next;
    public BookNode prev;
}

class LibraryList
{
    BookNode head;
    int count = 0;

    public void AddBook()
    {
        BookNode n = new BookNode();

        Console.Write("Book ID: ");
        n.id = int.Parse(Console.ReadLine());

        Console.Write("Title: ");
        n.title = Console.ReadLine();

        Console.Write("Author: ");
        n.author = Console.ReadLine();

        Console.Write("Genre: ");
        n.genre = Console.ReadLine();

        n.available = true;

        n.next = head;
        n.prev = null;

        if (head != null)
            head.prev = n;

        head = n;
        count++;

        Console.WriteLine("Book Added");
    }

    public void RemoveBook()
    {
        Console.Write("Book ID: ");
        int id = int.Parse(Console.ReadLine());

        BookNode temp = head;

        while (temp != null && temp.id != id)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Book Not Found");
            return;
        }

        if (temp.prev != null)
            temp.prev.next = temp.next;
        else
            head = temp.next;

        if (temp.next != null)
            temp.next.prev = temp.prev;

        count--;
        Console.WriteLine("Book Removed");
    }

    public void SearchBook()
    {
        Console.Write("Enter Title or Author: ");
        string input = Console.ReadLine();

        BookNode temp = head;

        while (temp != null)
        {
            if (temp.title == input || temp.author == input)
            {
                Console.WriteLine(temp.title + " by " + temp.author);
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Book Not Found");
    }

    public void UpdateStatus()
    {
        Console.Write("Book ID: ");
        int id = int.Parse(Console.ReadLine());

        BookNode temp = head;

        while (temp != null)
        {
            if (temp.id == id)
            {
                temp.available = !temp.available;
                Console.WriteLine("Availability Updated");
                return;
            }
            temp = temp.next;
        }
    }

    public void DisplayForward()
    {
        BookNode temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.title + " Available: " + temp.available);
            temp = temp.next;
        }
    }

    public void DisplayReverse()
    {
        BookNode temp = head;

        while (temp.next != null)
            temp = temp.next;

        while (temp != null)
        {
            Console.WriteLine(temp.title);
            temp = temp.prev;
        }
    }

    public void CountBooks()
    {
        Console.WriteLine("Total Books: " + count);
    }
}

class Program
{
    static void Main()
    {
        LibraryList list = new LibraryList();
        int ch;

        do
        {
            Console.WriteLine("\n--- Library Menu ---");
            Console.WriteLine("1.Add Book");
            Console.WriteLine("2.Remove Book");
            Console.WriteLine("3.Search Book");
            Console.WriteLine("4.Update Availability");
            Console.WriteLine("5.Display Forward");
            Console.WriteLine("6.Display Reverse");
            Console.WriteLine("7.Count Books");
            Console.WriteLine("8.Exit");
            Console.Write("Choice: ");

            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: list.AddBook(); break;
                case 2: list.RemoveBook(); break;
                case 3: list.SearchBook(); break;
                case 4: list.UpdateStatus(); break;
                case 5: list.DisplayForward(); break;
                case 6: list.DisplayReverse(); break;
                case 7: list.CountBooks(); break;
            }

        } while (ch != 8);
    }
}
