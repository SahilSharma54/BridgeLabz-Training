using System;
using System.Diagnostics;
using System.Reflection;

class Test
{
    public void Run()
    {
        for (int i = 0; i < 1000000; i++) { }
    }
}

class Program
{
    static void Main()
    {
        Test t = new Test();
        MethodInfo method = typeof(Test).GetMethod("Run");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(t, null);
        sw.Stop();

        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
