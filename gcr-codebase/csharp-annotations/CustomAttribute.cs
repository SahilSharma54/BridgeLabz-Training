using System;
using System.Reflection;

// Define custom attribute
[AttributeUsage(AttributeTargets.Method)]
class TaskInfo : Attribute
{
    public string Priority { get; set; }
    public string AssignedTo { get; set; }
}

class TaskManager
{
    // Apply custom attribute
    [TaskInfo(Priority = "High", AssignedTo = "Student Name you want")]
    public void ImportantTask()
    {
        Console.WriteLine("Performing important task...");
    }
}

class Program
{
    static void Main()
    {
        TaskManager tm = new TaskManager();

        // Use reflection to get attribute details
        MethodInfo method = typeof(TaskManager).GetMethod("ImportantTask");
        TaskInfo attr = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));

        Console.WriteLine("Task Details:");
        Console.WriteLine("Priority: " + attr.Priority);
        Console.WriteLine("Assigned To: " + attr.AssignedTo);

        tm.ImportantTask();
    }
}
