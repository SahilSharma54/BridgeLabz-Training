using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main()
    {
        MathOperations m = new MathOperations();
        Type t = typeof(MathOperations);

        Console.Write("Enter method name (Add/Subtract): ");
        string methodName = Console.ReadLine();

        MethodInfo method = t.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found");
            return;
        }

        object result = method.Invoke(m, new object[] { 10, 5 });

        Console.WriteLine("Result: " + result);
    }
}
