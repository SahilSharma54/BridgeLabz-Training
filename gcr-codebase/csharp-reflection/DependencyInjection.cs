using System;
using System.Reflection;

// Attribute Definition 
[AttributeUsage(AttributeTargets.Field)]
public class InjectAttribute : Attribute
{
}

// Services / Dependencies 
public class Logger
{
    public void Log(string msg)
    {
        Console.WriteLine("Log: " + msg);
    }
}

public class Database
{
    public void Connect()
    {
        Console.WriteLine("Database connected!");
    }
}

// Class That Needs Dependencies 
public class Application
{
    [Inject]  // Mark field for DI
    public Logger logger;

    [Inject]
    public Database database;

    public void Run()
    {
        logger.Log("Application started");
        database.Connect();
    }
}

// Simple DI Container 
public class DIContainer
{
    public static void InjectDependencies(object obj)
    {
        Type t = obj.GetType();

        // Get all instance fields (public & private)
        FieldInfo[] fields = t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var field in fields)
        {
            // Only inject fields with [Inject] attribute
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                // Create instance of the field type
                object dependency = Activator.CreateInstance(field.FieldType);

                // Set the field value
                field.SetValue(obj, dependency);
            }
        }
    }
}

// Main Program 
class Program
{
    static void Main()
    {
        // Create application object (no dependencies yet)
        Application app = new Application();

        // Inject dependencies automatically using reflection
        DIContainer.InjectDependencies(app);

        // Run the application
        app.Run();

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
