using System;
using System.Reflection;

// Define repeatable attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReport : Attribute
{
    public string Description { get; set; }
}

class ProgramManager
{
    // Apply attribute twice
    [BugReport(Description = "NullReference issue")]
    [BugReport(Description = "Performance issue")]
    public void ProcessTask()
    {
        Console.WriteLine("Processing task...");
    }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(ProgramManager).GetMethod("ProcessTask");

        // Retrieve all bug reports
        object[] bugs = method.GetCustomAttributes(typeof(BugReport), false);

        Console.WriteLine("Bug Reports for ProcessTask:");
        foreach (BugReport bug in bugs)
        {
            Console.WriteLine("- " + bug.Description);
        }

        ProgramManager pm = new ProgramManager();
        pm.ProcessTask();
    }
}
