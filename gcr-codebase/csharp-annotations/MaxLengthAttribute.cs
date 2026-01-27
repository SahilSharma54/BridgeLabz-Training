using System;
using System.Reflection;

// Step 1: Define custom attribute
[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    private int length;
    public int Length
    {
        get { return length; }
        set { length = value; }
    }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(5)]
    public string Username;

    public User(string username)
    {
        // Step 2: Validate length
        FieldInfo field = typeof(User).GetField("Username");
        object[] attrs = field.GetCustomAttributes(typeof(MaxLengthAttribute), false);

        if (attrs.Length > 0)
        {
            MaxLengthAttribute attr = (MaxLengthAttribute)attrs[0];
            if (username.Length > attr.Length)
            {
                throw new ArgumentException("Username cannot exceed " + attr.Length + " characters.");
            }
        }

        Username = username;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string input = Console.ReadLine();

        try
        {
            User u = new User(input);
            Console.WriteLine("Username '" + u.Username + "' is valid!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
