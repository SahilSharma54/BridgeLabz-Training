using System;

class MovieNode
{
    public string title;
    public string director;
    public int year;
    public double rating;
    public MovieNode next;
    public MovieNode prev;
}

class MovieList
{
    MovieNode head;

    public void AddMovie()
    {
        MovieNode newNode = new MovieNode();

        Console.Write("Title: ");
        newNode.title = Console.ReadLine();

        Console.Write("Director: ");
        newNode.director = Console.ReadLine();

        Console.Write("Year: ");
        newNode.year = int.Parse(Console.ReadLine());

        Console.Write("Rating: ");
        newNode.rating = double.Parse(Console.ReadLine());

        newNode.next = head;
        newNode.prev = null;

        if (head != null)
            head.prev = newNode;

        head = newNode;

        Console.WriteLine("Movie Added");
    }

    public void RemoveMovie()
    {
        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        MovieNode temp = head;

        while (temp != null && temp.title != title)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Movie Not Found");
            return;
        }

        if (temp.prev != null)
            temp.prev.next = temp.next;
        else
            head = temp.next;

        if (temp.next != null)
            temp.next.prev = temp.prev;

        Console.WriteLine("Movie Removed");
    }

    public void DisplayForward()
    {
        MovieNode temp = head;

        while (temp != null)
        {
            Console.WriteLine(temp.title + " - " + temp.rating);
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        MovieList list = new MovieList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Movie Menu ---");
            Console.WriteLine("1.Add Movie");
            Console.WriteLine("2.Remove Movie");
            Console.WriteLine("3.Display Movies");
            Console.WriteLine("4.Exit");
            Console.Write("Choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: list.AddMovie(); break;
                case 2: list.RemoveMovie(); break;
                case 3: list.DisplayForward(); break;
            }

        } while (choice != 4);
    }
}
