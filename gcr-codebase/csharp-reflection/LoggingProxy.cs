using System;
using System.Reflection;

interface IGreeting
{
    void SayHello();
}

class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class Program
{
    static void Main()
    {
        IGreeting g = new Greeting();
        MethodInfo method = g.GetType().GetMethod("SayHello");

        Console.WriteLine("Calling method: " + method.Name);
        method.Invoke(g, null);
    }
}
