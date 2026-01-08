using System;

class TextNode
{
    public string text;
    public TextNode next;
    public TextNode prev;
}

class TextEditor
{
    TextNode head;
    TextNode current;
    int count = 0;
    int limit = 10;

    public void AddState()
    {
        TextNode n = new TextNode();

        Console.Write("Enter Text: ");
        n.text = Console.ReadLine();

        if (head == null)
        {
            head = n;
            current = n;
        }
        else
        {
            current.next = n;
            n.prev = current;
            current = n;
        }

        count++;
        Console.WriteLine("State Saved");
    }

    public void Undo()
    {
        if (current != null && current.prev != null)
        {
            current = current.prev;
            Console.WriteLine("Undo Done");
        }
        else
        {
            Console.WriteLine("No Undo Possible");
        }
    }

    public void Redo()
    {
        if (current != null && current.next != null)
        {
            current = current.next;
            Console.WriteLine("Redo Done");
        }
        else
        {
            Console.WriteLine("No Redo Possible");
        }
    }

    public void Display()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.text);
        else
            Console.WriteLine("Empty");
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();
        int ch;

        do
        {
            Console.WriteLine("\n--- Text Editor Menu ---");
            Console.WriteLine("1.Type Text");
            Console.WriteLine("2.Undo");
            Console.WriteLine("3.Redo");
            Console.WriteLine("4.Display Text");
            Console.WriteLine("5.Exit");
            Console.Write("Choice: ");

            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: editor.AddState(); break;
                case 2: editor.Undo(); break;
                case 3: editor.Redo(); break;
                case 4: editor.Display(); break;
            }

        } while (ch != 5);
    }
}
