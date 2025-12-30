

/*

Library Management System – Book Search and Checkout
Scenario: You’re designing a system for a small library to manage books and track checkouts.
Problem Requirements:
● Store book details (title, author, status) in a Array.
● Allow searching by partial title using String operations.
● Store book data in an Array.
● Use methods for searching, displaying, and updating book status (checked out or
available).

*/





using System;

class LibraryManagement{

    // Method to enter book details
    static void BookEntry(string[] title,string[] author,string[] status){
        for(int i=0;i<title.Length;i++){
            Console.WriteLine("Enter Title of Book " + (i+1));
            title[i]=Console.ReadLine();

            Console.WriteLine("Enter Author of Book " + (i+1));
            author[i]=Console.ReadLine();

            status[i]="Available"; // default status
        }
    }

    // Method to search book by partial title
    static void SearchBook(string[] title,string[] author,string[] status){
        Console.WriteLine("Enter book title to search:");
        string search=Console.ReadLine().ToLower();

        bool found=false;

        for(int i=0;i<title.Length;i++){
            if(title[i].ToLower().Contains(search)){
                Console.WriteLine("Book Found:");
                Console.WriteLine("Title: " + title[i]);
                Console.WriteLine("Author: " + author[i]);
                Console.WriteLine("Status: " + status[i]);
                found=true;
            }
        }

        if(!found){
            Console.WriteLine("No book found.");
        }
    }

    // Method to display all books
    static void DisplayBooks(string[] title,string[] author,string[] status){
        Console.WriteLine("----- Book List -----");

        for(int i=0;i<title.Length;i++){
            Console.WriteLine("Book " + (i+1));
            Console.WriteLine("Title: " + title[i]);
            Console.WriteLine("Author: " + author[i]);
            Console.WriteLine("Status: " + status[i]);
            Console.WriteLine("----------------------");
        }
    }

    // Method to update book status
    static void UpdateStatus(string[] title,string[] status){
        Console.WriteLine("Enter book title to update status:");
        string search=Console.ReadLine().ToLower();

        for(int i=0;i<title.Length;i++){
            if(title[i].ToLower().Contains(search)){
                Console.WriteLine("Enter new status (Available / Checked Out):");
                status[i]=Console.ReadLine();
                Console.WriteLine("Status updated successfully.");
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    static void Main(string[] args){

        Console.WriteLine("================ WELCOME TO THE LIBRARY MANAGEMENT SYSTEM ================");
        Console.WriteLine("Enter number of books:");
        int numberOfBooks=int.Parse(Console.ReadLine());

        // Array creation
        string[] title=new string[numberOfBooks];
        string[] author=new string[numberOfBooks];
        string[] status=new string[numberOfBooks];

        int userInput=0;

        // Loop runs until user presses 5
        while(userInput!=5){

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Book Entry");
            Console.WriteLine("2. Search Book");
            Console.WriteLine("3. Display All Books");
            Console.WriteLine("4. Update Book Status");
            Console.WriteLine("5. Exit");

            userInput=int.Parse(Console.ReadLine());

            switch(userInput){
                case 1:
                    BookEntry(title,author,status);
                    break;

                case 2:
                    SearchBook(title,author,status);
                    break;

                case 3:
                    DisplayBooks(title,author,status);
                    break;

                case 4:
                    UpdateStatus(title,status);
                    break;

                case 5:
                    Console.WriteLine("Thank you for using Library Management System.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
