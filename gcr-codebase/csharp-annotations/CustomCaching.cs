using System;
using System.Reflection;
using System.Collections.Generic;

// Step 1: Define CacheResult attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

class Program
{
    // Dictionary to store cached results
    private Dictionary<int, long> cache;

    public Program()
    {
        cache = new Dictionary<int, long>();
    }

    [CacheResult]
    public long Factorial(int n)
    {
        if (cache.ContainsKey(n))
        {
            Console.WriteLine("Returning cached result for " + n);
            return cache[n];
        }

        long result = 1;
        for (int i = 2; i <= n; i++)
            result *= i;

        cache[n] = result; // Store in cache
        return result;
    }

    static void Main()
    {
        Program p = new Program();
        Type t = typeof(Program);

        Console.WriteLine("Enter number to calculate factorial:");
        int num = int.Parse(Console.ReadLine());

        // Step 2: Find method with CacheResult attribute
        MethodInfo method = t.GetMethod("Factorial");
        object[] attrs = method.GetCustomAttributes(typeof(CacheResultAttribute), false);

        if (attrs.Length > 0)
        {
            CacheResultAttribute attr = (CacheResultAttribute)attrs[0];

            // Call method multiple times to test caching
            object result1 = method.Invoke(p, new object[] { num });
            Console.WriteLine("Factorial(" + num + ") = " + result1);

            object result2 = method.Invoke(p, new object[] { num });
            Console.WriteLine("Factorial(" + num + ") again = " + result2);
        }
    }
}
