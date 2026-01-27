using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class Program
{
    static void Main()
    {
        Type t = typeof(Configuration);

        FieldInfo field = t.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        Console.WriteLine("Old Key: " + field.GetValue(null));

        field.SetValue(null, "NEW_KEY");

        Console.WriteLine("New Key: " + field.GetValue(null));
    }
}
