using System;
using System.Reflection;

// Step 1: Define custom annotations
[AttributeUsage(AttributeTargets.Method)]
class PublicAPIAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Method)]
class RequiresAuthAttribute : Attribute { }

// Step 2: Sample API controller
class LabController
{
    [PublicAPI]
    public void GetTestResults() { }

    [RequiresAuth]
    public void SubmitTestResults() { }

    // Missing annotation intentionally
    public void DeleteTestResults() { }
}

class Program
{
    static void Main()
    {
        LabController controller = new LabController();
        Type t = typeof(LabController);

        Console.WriteLine("HealthCheckPro – API Metadata Validator\n");

        // Menu driven
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Scan all API methods");
        Console.WriteLine("2. Exit");

        string choice = Console.ReadLine();
        if (choice == "1")
        {
            MethodInfo[] methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            for (int i = 0; i < methods.Length; i++)
            {
                MethodInfo m = methods[i];

                // Old-style GetCustomAttributes
                object[] publicAttrs = m.GetCustomAttributes(typeof(PublicAPIAttribute), false);
                object[] authAttrs = m.GetCustomAttributes(typeof(RequiresAuthAttribute), false);

                bool hasPublicAPI = publicAttrs.Length > 0;
                bool hasRequiresAuth = authAttrs.Length > 0;

                
                Console.WriteLine("\nMethod: " + m.Name);

                if (!hasPublicAPI && !hasRequiresAuth)
                {
                    Console.WriteLine(" Missing both annotations!");
                }
                else
                {
                    if (hasPublicAPI) Console.WriteLine(" Has [PublicAPI]");
                    if (hasRequiresAuth) Console.WriteLine(" Has [RequiresAuth]");
                }
            }
        }
        else
        {
            Console.WriteLine("Exiting...");
        }
    }
}
