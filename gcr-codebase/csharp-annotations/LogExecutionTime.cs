using System;
using System.Diagnostics;
using System.Reflection;

// Step 1: Define custom attribute
[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

class Program
{
    [LogExecutionTime]
    public void Process1()
    {
        System.Threading.Thread.Sleep(500); // Simulate work
    }

    [LogExecutionTime]
    public void Process2()
    {
        System.Threading.Thread.Sleep(1000); // Simulate work
    }

    static void Main()
    {
        Program p = new Program();
        Type t = typeof(Program);

        
        MethodInfo[] methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        for (int i = 0; i < methods.Length; i++)
        {
            MethodInfo m = methods[i];

            // Use old-style casting instead of generic GetCustomAttribute<T>()
            object[] attrs = m.GetCustomAttributes(typeof(LogExecutionTimeAttribute), false);
            if (attrs.Length > 0)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.Invoke(p, null);
                sw.Stop();

                
                Console.WriteLine("Method " + m.Name + " executed in " + sw.ElapsedMilliseconds + " ms");
            }
        }
    }
}
