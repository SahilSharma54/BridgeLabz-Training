using System;

class StudentNode
{
    public int roll;
    public string name;
    public int age;
    public char grade;
    public StudentNode next;
}

class StudentLinkedList
{
    private StudentNode head;

    public void AddStudent()
    {
        StudentNode newNode = new StudentNode();

        Console.Write("Enter Roll Number: ");
        newNode.roll = int.Parse(Console.ReadLine());

        Console.Write("Enter Name: ");
        newNode.name = Console.ReadLine();

        Console.Write("Enter Age: ");
        newNode.age = int.Parse(Console.ReadLine());

        Console.Write("Enter Grade: ");
        newNode.grade = char.Parse(Console.ReadLine());

        newNode.next = head;
        head = newNode;

        Console.WriteLine("Student Added Successfully");
    }

    public void DeleteStudent()
    {
        Console.Write("Enter Roll Number to Delete: ");
        int roll = int.Parse(Console.ReadLine());

        StudentNode temp = head, prev = null;

        while (temp != null && temp.roll != roll)
        {
            prev = temp;
            temp = temp.next;
        }

        if (temp == null)
        {
            Console.WriteLine("Student Not Found");
            return;
        }

        if (prev == null)
            head = temp.next;
        else
            prev.next = temp.next;

        Console.WriteLine("Student Deleted");
    }

    public void SearchStudent()
    {
        Console.Write("Enter Roll Number to Search: ");
        int roll = int.Parse(Console.ReadLine());

        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.roll == roll)
            {
                Console.WriteLine("Found: " + temp.name);
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Student Not Found");
    }

    public void UpdateGrade()
    {
        Console.Write("Enter Roll Number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter New Grade: ");
        char grade = char.Parse(Console.ReadLine());

        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.roll == roll)
            {
                temp.grade = grade;
                Console.WriteLine("Grade Updated");
                return;
            }
            temp = temp.next;
        }

        Console.WriteLine("Student Not Found");
    }

    public void Display()
    {
        StudentNode temp = head;

        if (temp == null)
        {
            Console.WriteLine("No Records");
            return;
        }

        while (temp != null)
        {
            Console.WriteLine(
                "Roll: " + temp.roll +
                ", Name: " + temp.name +
                ", Age: " + temp.age +
                ", Grade: " + temp.grade);
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Record Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Delete Student");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Grade");
            Console.WriteLine("5. Display Students");
            Console.WriteLine("6. Exit");
            Console.Write("Enter Choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: list.AddStudent(); break;
                case 2: list.DeleteStudent(); break;
                case 3: list.SearchStudent(); break;
                case 4: list.UpdateGrade(); break;
                case 5: list.Display(); break;
            }
        } while (choice != 6);
    }
}
