using System;
using System.Reflection;

class Sample
{
    public int x;
    private string name;

    public Sample() { }
    public Sample(int x) { }

    public void Show() { }
    private void Hidden() { }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        Type t = Type.GetType(className);

        if (t == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (var m in t.GetMethods())
            Console.WriteLine(m.Name);

        Console.WriteLine("\nFields:");
        foreach (var f in t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            Console.WriteLine(f.Name);

        Console.WriteLine("\nConstructors:");
        foreach (var c in t.GetConstructors())
            Console.WriteLine(c);
    }
}
