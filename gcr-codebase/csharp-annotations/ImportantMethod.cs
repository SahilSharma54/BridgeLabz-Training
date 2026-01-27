using System;
using System.Reflection;

// Define custom attribute
[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; set; }  // No auto-initializer

    // Default constructor sets default level
    public ImportantMethodAttribute()
    {
        Level = "HIGH";
    }

    // Constructor with parameter
    public ImportantMethodAttribute(string level)
    {
        Level = level;
    }
}

class Program
{
    // Apply attribute to methods
    [ImportantMethod] // Uses default "HIGH"
    public void Feature1()
    {
        Console.WriteLine("Feature1 executed");
    }

    [ImportantMethod("LOW")]
    public void Feature2()
    {
        Console.WriteLine("Feature2 executed");
    }

    static void Main()
    {
        Program p = new Program();
        Type t = typeof(Program);

        // Retrieve methods with attribute
        foreach (MethodInfo m in t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            ImportantMethodAttribute attr = (ImportantMethodAttribute)m.GetCustomAttribute(typeof(ImportantMethodAttribute));
            if (attr != null)
            {
                
                Console.WriteLine("Method: " + m.Name + ", Importance Level: " + attr.Level);
            }
        }
    }
}
