/*

BrowserBuddy – Tab History Manager (Doubly Linked List + Stack)
Story: Neha is working on a custom browser. Each open tab maintains its browsing history with
"Back" and "Forward" operations. She uses a Doubly Linked List for history and a Stack to
hold closed tabs for reopening. Requirements:
● Support forward and backward navigation.
● Restore recently closed tabs.
● Maintain memory-efficient tab management using pointers.

*/



using System;

namespace BrowserBuddy
{
    // Doubly Linked List Node
    class Page
    {
        public string Url;
        public Page Prev;
        public Page Next;

        public Page(string url)
        {
            Url = url;
            Prev = null;
            Next = null;
        }
    }

    // Stack Node for Closed Tabs
    class ClosedTab
    {
        public Page PageData;
        public ClosedTab Next;

        public ClosedTab(Page page)
        {
            PageData = page;
            Next = null;
        }
    }

    class Browser
    {
        private Page current;   // Current page
        private ClosedTab top;  // Top of closed tab stack

        public Browser()
        {
            current = null;
            top = null;
        }

        // Visit a new page
        public void Visit(string url)
        {
            Page newPage = new Page(url);

            if (current != null)
            {
                current.Next = newPage;
                newPage.Prev = current;
            }

            current = newPage;
            Console.WriteLine("Visited: " + url);
        }

        // Go back
        public void Back()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Moved back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No previous page available");
            }
        }

        // Go forward
        public void Forward()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Moved forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No next page available");
            }
        }

        // Close current tab
        public void CloseTab()
        {
            if (current == null)
            {
                Console.WriteLine("No tab to close");
                return;
            }

            ClosedTab temp = new ClosedTab(current);
            temp.Next = top;
            top = temp;

            Console.WriteLine("Closed tab: " + current.Url);
            current = current.Prev; // Move back
        }

        // Restore closed tab
        public void RestoreTab()
        {
            if (top == null)
            {
                Console.WriteLine("No closed tabs to restore");
                return;
            }

            current = top.PageData;
            top = top.Next;

            Console.WriteLine("Restored tab: " + current.Url);
        }

        // Display current page
        public void ShowCurrent()
        {
            if (current != null)
            {
                Console.WriteLine("Current Page: " + current.Url);
            }
            else
            {
                Console.WriteLine("No page open");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Browser browser = new Browser();
            int choice;

            do
            {
                Console.WriteLine("\n===== BrowserBuddy Menu =====");
                Console.WriteLine("1. Visit New Page");
                Console.WriteLine("2. Back");
                Console.WriteLine("3. Forward");
                Console.WriteLine("4. Close Current Tab");
                Console.WriteLine("5. Restore Closed Tab");
                Console.WriteLine("6. Show Current Page");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter URL: ");
                        string url = Console.ReadLine();
                        browser.Visit(url);
                        break;

                    case 2:
                        browser.Back();
                        break;

                    case 3:
                        browser.Forward();
                        break;

                    case 4:
                        browser.CloseTab();
                        break;

                    case 5:
                        browser.RestoreTab();
                        break;

                    case 6:
                        browser.ShowCurrent();
                        break;

                    case 7:
                        Console.WriteLine("Exiting BrowserBuddy...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            } while (choice != 7);
        }
    }
}

