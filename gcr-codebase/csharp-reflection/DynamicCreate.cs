using System;
using System.Reflection;

class Student
{
    public string Name = "Any Student Name That you want";
}

class Program
{
    static void Main()
    {
        Type t = typeof(Student);
        object obj = Activator.CreateInstance(t);

        Console.WriteLine("Object created dynamically");
    }
}
