using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int Id;
    public string Name;
    public int Age;
}

class CSVToObject
{
    static void Main()
    {
        // Read all lines from CSV file
        string[] lines = File.ReadAllLines("SampleData.csv");

        // Create list to store student objects
        List<Student> students = new List<Student>();

        // Skip header row
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            // Create Student object
            Student s = new Student();
            s.Id = int.Parse(data[0]);
            s.Name = data[1];
            s.Age = int.Parse(data[2]);

            // Add to list
            students.Add(s);
        }

        // Display student data
        foreach (Student s in students)
        {
            Console.WriteLine(s.Id + " " + s.Name + " " + s.Age);
        }
    }
}
