using System;
using System.Reflection;

class User
{
    public string Name = "Smarty";
    public int Age = 21;
}

class Program
{
    static void Main()
    {
        User u = new User();
        Type t = typeof(User);

        Console.Write("{ ");
        foreach (var f in t.GetFields())
        {
            Console.Write("\"" + f.Name + "\": \"" + f.GetValue(u) + "\" ");
        }
        Console.Write("}");
    }
}
