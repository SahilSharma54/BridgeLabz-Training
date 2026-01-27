using System;
using System.Reflection;

// Step 1: Define custom attribute
[AttributeUsage(AttributeTargets.Method)]
class TodoAttribute : Attribute
{
    private string priority;

    public string Task;
    public string AssignedTo;
    public string Priority
    {
        get { return priority; }
        set { priority = value; }
    }

    // Constructor
    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = "MEDIUM"; // Set default value here
    }
}

class Program
{
    // Use constructor + property to set HIGH priority
    [Todo("Implement login", "Sahil", Priority = "HIGH")]
    public void LoginFeature() { }

    [Todo("Add search", "Sajal")]
    public void SearchFeature() { }

    static void Main()
    {
        Type t = typeof(Program);

        // Older compilers may not support 'var'
        foreach (MethodInfo m in t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
        {
            TodoAttribute attr = (TodoAttribute)m.GetCustomAttribute(typeof(TodoAttribute));
            if (attr != null)
            {
                Console.WriteLine("Method: " + m.Name);
                Console.WriteLine("  Task: " + attr.Task);
                Console.WriteLine("  AssignedTo: " + attr.AssignedTo);
                Console.WriteLine("  Priority: " + attr.Priority);
            }
        }
    }
}
