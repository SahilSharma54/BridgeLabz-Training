using System;

class ProcessNode
{
    public int pid;
    public int burst;
    public int remaining;
    public ProcessNode next;
}

class RoundRobin
{
    ProcessNode head;

    public void AddProcess()
    {
        ProcessNode n = new ProcessNode();

        Console.Write("Process ID: ");
        n.pid = int.Parse(Console.ReadLine());

        Console.Write("Burst Time: ");
        n.burst = int.Parse(Console.ReadLine());
        n.remaining = n.burst;

        if (head == null)
        {
            head = n;
            n.next = head;
        }
        else
        {
            ProcessNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = n;
            n.next = head;
        }

        Console.WriteLine("Process Added");
    }

    public void Execute()
    {
        Console.Write("Enter Time Quantum: ");
        int tq = int.Parse(Console.ReadLine());

        ProcessNode temp = head;

        while (head != null)
        {
            if (temp.remaining > 0)
            {
                if (temp.remaining > tq)
                {
                    temp.remaining -= tq;
                }
                else
                {
                    Console.WriteLine("Process " + temp.pid + " Completed");
                    temp.remaining = 0;
                }
            }
            temp = temp.next;

            bool done = true;
            ProcessNode check = head;

            do
            {
                if (check.remaining > 0)
                {
                    done = false;
                    break;
                }
                check = check.next;
            } while (check != head);

            if (done)
                break;
        }
    }

    public void Display()
    {
        if (head == null) return;

        ProcessNode temp = head;
        do
        {
            Console.WriteLine("PID: " + temp.pid + " Remaining: " + temp.remaining);
            temp = temp.next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobin rr = new RoundRobin();
        int ch;

        do
        {
            Console.WriteLine("\n--- Round Robin Menu ---");
            Console.WriteLine("1.Add Process");
            Console.WriteLine("2.Execute");
            Console.WriteLine("3.Display");
            Console.WriteLine("4.Exit");
            Console.Write("Choice: ");

            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: rr.AddProcess(); break;
                case 2: rr.Execute(); break;
                case 3: rr.Display(); break;
            }

        } while (ch != 4);
    }
}
