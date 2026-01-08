using System;

class UserNode
{
    public int id;
    public string name;
    public int age;
    public int friendCount;
    public UserNode next;
}

class SocialMediaList
{
    UserNode head;

    public void AddUser()
    {
        UserNode n = new UserNode();

        Console.Write("User ID: ");
        n.id = int.Parse(Console.ReadLine());

        Console.Write("Name: ");
        n.name = Console.ReadLine();

        Console.Write("Age: ");
        n.age = int.Parse(Console.ReadLine());

        n.friendCount = 0;
        n.next = head;
        head = n;

        Console.WriteLine("User Added");
    }

    public UserNode FindUser(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.id == id)
                return temp;
            temp = temp.next;
        }
        return null;
    }

    public void AddFriend()
    {
        Console.Write("Enter User1 ID: ");
        int u1 = int.Parse(Console.ReadLine());

        Console.Write("Enter User2 ID: ");
        int u2 = int.Parse(Console.ReadLine());

        UserNode user1 = FindUser(u1);
        UserNode user2 = FindUser(u2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("User Not Found");
            return;
        }

        user1.friendCount++;
        user2.friendCount++;

        Console.WriteLine("Friend Connection Added");
    }

    public void RemoveFriend()
    {
        Console.Write("Enter User1 ID: ");
        int u1 = int.Parse(Console.ReadLine());

        Console.Write("Enter User2 ID: ");
        int u2 = int.Parse(Console.ReadLine());

        UserNode user1 = FindUser(u1);
        UserNode user2 = FindUser(u2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("User Not Found");
            return;
        }

        user1.friendCount--;
        user2.friendCount--;

        Console.WriteLine("Friend Connection Removed");
    }

    public void SearchUser()
    {
        Console.Write("Enter ID or Name: ");
        string input = Console.ReadLine();

        UserNode temp = head;
        while (temp != null)
        {
            if (temp.id.ToString() == input || temp.name == input)
            {
                Console.WriteLine("User Found: " + temp.name);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("User Not Found");
    }

    public void Display()
    {
        UserNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(
                "ID: " + temp.id +
                " Name: " + temp.name +
                " Friends: " + temp.friendCount);
            temp = temp.next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMediaList list = new SocialMediaList();
        int ch;

        do
        {
            Console.WriteLine("\n--- Social Media Menu ---");
            Console.WriteLine("1.Add User");
            Console.WriteLine("2.Add Friend");
            Console.WriteLine("3.Remove Friend");
            Console.WriteLine("4.Search User");
            Console.WriteLine("5.Display Users");
            Console.WriteLine("6.Exit");
            Console.Write("Choice: ");

            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1: list.AddUser(); break;
                case 2: list.AddFriend(); break;
                case 3: list.RemoveFriend(); break;
                case 4: list.SearchUser(); break;
                case 5: list.Display(); break;
            }

        } while (ch != 6);
    }
}
