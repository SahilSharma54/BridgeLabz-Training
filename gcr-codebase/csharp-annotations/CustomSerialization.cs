using System;
using System.Reflection;
using System.Collections.Generic;

// Step 1: Define JsonField attribute
[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    private string key;

    public string Key
    {
        get { return key; }
        set { key = value; }
    }

    public JsonFieldAttribute(string key)
    {
        Key = key;
    }
}

class User
{
    [JsonField("user_name")]
    public string Name;

    [JsonField("user_age")]
    public int Age;

    public User(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static string ToJson(object obj)
    {
        Type t = obj.GetType();
        List<string> jsonParts = new List<string>();

        FieldInfo[] fields = t.GetFields();
        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo f = fields[i];

            // Use old-style GetCustomAttributes
            object[] attrs = f.GetCustomAttributes(typeof(JsonFieldAttribute), false);
            if (attrs.Length > 0)
            {
                JsonFieldAttribute attr = (JsonFieldAttribute)attrs[0];
                object value = f.GetValue(obj);

                string jsonValue;
                if (value is string)
                {
                    jsonValue = "\"" + value + "\"";
                }
                else
                {
                    jsonValue = value.ToString();
                }

                jsonParts.Add("\"" + attr.Key + "\": " + jsonValue);
            }
        }

        return "{" + string.Join(", ", jsonParts.ToArray()) + "}";
    }

    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        User u = new User(name, age);

        string json = ToJson(u);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);
    }
}
