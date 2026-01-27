using System;
using System.Reflection;

// Step 1: Define the RoleAllowed attribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    private string role;

    public string Role
    {
        get { return role; }
        set { role = value; }
    }

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class Program
{
    // Step 2: Apply attribute to methods
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed successfully!");
    }

    public void GeneralTask()
    {
        Console.WriteLine("General task executed.");
    }

    static void Main()
    {
        Program p = new Program();

        Console.Write("Enter your role: ");
        string userRole = Console.ReadLine().ToUpper();

        Type t = typeof(Program);
        MethodInfo[] methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        for (int i = 0; i < methods.Length; i++)
        {
            MethodInfo m = methods[i];

            // Use old-style GetCustomAttributes
            object[] attrs = m.GetCustomAttributes(typeof(RoleAllowedAttribute), false);

            if (attrs.Length > 0)
            {
                RoleAllowedAttribute attr = (RoleAllowedAttribute)attrs[0];

                if (userRole == attr.Role)
                {
                    m.Invoke(p, null); // Access granted
                }
                else
                {
                    Console.WriteLine("Access Denied for method " + m.Name + "!");
                }
            }
            else
            {
                m.Invoke(p, null); // Methods without attribute are open
            }
        }
    }
}
