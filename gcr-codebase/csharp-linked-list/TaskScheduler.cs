using System;

class TaskNode
{
    public int id;
    public string name;
    public int priority;
    public TaskNode next;
}

class TaskCircularList
{
    TaskNode head;

    public void AddTask()
    {
        TaskNode newNode = new TaskNode();

        Console.Write("Task ID: ");
        newNode.id = int.Parse(Console.ReadLine());

        Console.Write("Task Name: ");
        newNode.name = Console.ReadLine();

        Console.Write("Priority: ");
        newNode.priority = int.Parse(Console.ReadLine());

        if (head == null)
        {
            head = newNode;
            newNode.next = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.next != head)
                temp = temp.next;

            temp.next = newNode;
            newNode.next = head;
        }

        Console.WriteLine("Task Added");
    }

    public void Display()
    {
        if (head == null)
        {
            Console.WriteLine("No Tasks");
            return;
        }

        TaskNode temp = head;
        do
        {
            Console.WriteLine("ID: " + temp.id +
                              ", Task: " + temp.name +
                              ", Priority: " + temp.priority);
            temp = temp.next;
        }
        while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        TaskCircularList list = new TaskCircularList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Task Menu ---");
            Console.WriteLine("1.Add Task");
            Console.WriteLine("2.Display Tasks");
            Console.WriteLine("3.Exit");
            Console.Write("Choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: list.AddTask(); break;
                case 2: list.Display(); break;
            }

        } while (choice != 3);
    }
}
