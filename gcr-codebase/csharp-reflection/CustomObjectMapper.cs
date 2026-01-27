using System;
using System.Collections.Generic;
using System.Reflection;

class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static T ToObject<T>(Dictionary<string, object> data) where T : new()
    {
        T obj = new T();
        Type t = typeof(T);

        foreach (var item in data)
        {
            FieldInfo field = t.GetField(item.Key);
            field.SetValue(obj, item.Value);
        }
        return obj;
    }

    static void Main()
    {
        var dict = new Dictionary<string, object>
        {
            {"Name", "Student Name"},
            {"Age", 22}
        };

        Person p = ToObject<Person>(dict);

        Console.WriteLine(p.Name + " - " + p.Age);
    }
}
