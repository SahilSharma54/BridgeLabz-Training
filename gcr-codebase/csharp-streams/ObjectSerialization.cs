// Basic namespaces for input/output and collections
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

// DataContract attribute is required for JSON serialization
[DataContract]
class Employee
{
    // DataMember attributes mark fields to be serialized
    [DataMember]
    public int Id;

    [DataMember]
    public string Name;

    [DataMember]
    public string Department;

    [DataMember]
    public double Salary;
}

class SerializationDemo
{
    static void Main()
    {
        // Create a list to store employee objects
        List<Employee> employees = new List<Employee>();

        // Read number of employees from user
        Console.Write("Enter number of employees: ");
        int n = int.Parse(Console.ReadLine());

        // Loop to accept employee details
        for (int i = 0; i < n; i++)
        {
            // Create a new Employee object
            Employee emp = new Employee();

            // Read employee ID
            Console.Write("Enter ID: ");
            emp.Id = int.Parse(Console.ReadLine());

            // Read employee name
            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            // Read employee department
            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            // Read employee salary
            Console.Write("Enter Salary: ");
            emp.Salary = double.Parse(Console.ReadLine());

            // Add employee object to the list
            employees.Add(emp);
        }

        try
        {
            // SERIALIZATION 

            // Create file stream to write JSON data
            FileStream fs = new FileStream("Sample.json", FileMode.Create);

            // Create JSON serializer for List<Employee>
            DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(List<Employee>));

            // Write employee list into JSON file
            serializer.WriteObject(fs, employees);

            // Close the file stream
            fs.Close();

            Console.WriteLine("Employees saved successfully.");

            // DESERIALIZATION 

            // Open file stream to read JSON data
            FileStream fs2 = new FileStream("Sample.json", FileMode.Open);

            // Read JSON data and convert it back to List<Employee>
            List<Employee> empList =
                (List<Employee>)serializer.ReadObject(fs2);

            // Close the file stream
            fs2.Close();

            // Display deserialized employee details
            Console.WriteLine("\nEmployee Details:");
            foreach (Employee e in empList)
            {
                Console.WriteLine(e.Id + " " +e.Name + " " +e.Department + " " +
                    e.Salary
                );
            }
        }
        catch (Exception e)
        {
            // Display error message if any exception occurs
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
