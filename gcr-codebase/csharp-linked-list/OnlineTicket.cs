using System;

class TicketNode
{
    public int ticketId;
    public string customer;
    public string movie;
    public int seat;
    public TicketNode next;
}

class TicketSystem
{
    TicketNode head;
    int count = 0;

    public void AddTicket()
    {
        TicketNode n = new TicketNode();

        Console.Write("Ticket ID: ");
        n.ticketId = int.Parse(Console.ReadLine());

        Console.Write("Customer Name: ");
        n.customer = Console.ReadLine();

        Console.Write("Movie Name: ");
        n.movie = Console.ReadLine();

        Console.Write("Seat Number: ");
        n.seat = int.Parse(Console.ReadLine());

        if (head == null)
        {
            head = n;
            n.next = head;
        }
        else
        {
            TicketNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = n;
            n.next = head;
        }

        count++;
        Console.WriteLine("Ticket Booked");
    }

    public void RemoveTicket()
    {
        Console.Write("Enter Ticket ID: ");
        int id = int.Parse(Console.ReadLine());

        TicketNode temp = head, prev = null;

        do
        {
            if (temp.ticketId == id)
            {
                if (prev != null)
                    prev.next = temp.next;
                else
                {
                    TicketNode last = head;
                    while (last.next != head)
                        last = last.next;

                    head = temp.next;
                    last.next = head;
                }

                count--;
                Console.WriteLine("Ticket Cancelled");
                return;
            }

            prev = temp;
            temp = temp.next;

        } while (temp != head);

        Console.WriteLine("Ticket Not Found");
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No Tickets");
            return;
        }

        TicketNode temp = head;
        do
        {
            Console.WriteLine(
                "TicketID: " + temp.ticketId +
                " Customer: " + temp.customer +
                " Movie: " + temp.movie +
                " Seat: " + temp.seat);
            temp = temp.next;
        } while (temp != head);
    }

    public void CountTickets()
    {
        Console.WriteLine("Total Tickets: " + count);
    }
}

class Program
{
    static void Main()
    {
        TicketSystem ts = new TicketSystem();
        int ch;

        do
        {
            Console.WriteLine("\n--- Ticket Menu ---");
            Console.WriteLine("1.Book Ticket");
            Console.WriteLine("2.Cancel Ticket");
            Console.WriteLine("3.Display Tickets");
            Console.WriteLine("4.Count Tickets");
            Console.WriteLine("5.Exit");
            Console.Write("Choice: ");

            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: ts.AddTicket(); break;
                case 2: ts.RemoveTicket(); break;
                case 3: ts.Display(); break;
                case 4: ts.CountTickets(); break;
            }

        } while (ch != 5);
    }
}
