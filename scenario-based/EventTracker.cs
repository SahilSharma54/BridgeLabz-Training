using System;
using System.Reflection;

// Step 1: Define custom annotation
[AttributeUsage(AttributeTargets.Method)]
class AuditTrailAttribute : Attribute { }

// Step 2: Sample system actions
class UserActions
{
    [AuditTrail]
    public void Login() { }

    [AuditTrail]
    public void UploadFile() { }

    public void DeleteFile() { } // Not audited
}

class Program
{
    static void Main()
    {
        UserActions actions = new UserActions();
        Type t = typeof(UserActions);

        Console.WriteLine("EventTracker – Auto Audit System\n");

        // Menu driven
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Generate JSON audit logs");
        Console.WriteLine("2. Exit");

        string choice = Console.ReadLine();
        if (choice == "1")
        {
            MethodInfo[] methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo m = methods[i];

                // Old-style GetCustomAttributes
                object[] attrs = m.GetCustomAttributes(typeof(AuditTrailAttribute), false);
                if (attrs.Length > 0)
                {
                    // Manually build JSON string
                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string json = "{\n" +
                                  "  \"Method\": \"" + m.Name + "\",\n" +
                                  "  \"Timestamp\": \"" + timestamp + "\",\n" +
                                  "  \"Metadata\": \"" + "Auto-generated audit for method " + m.Name + "\"\n" +
                                  "}";

                    Console.WriteLine(json);
                }
            }
        }
        else
        {
            Console.WriteLine("Exiting...");
        }
    }
}
