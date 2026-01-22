using System;
using System.IO;

class BinaryStudentData
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Roll Number: ");
            int roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter GPA: ");
            double gpa = double.Parse(Console.ReadLine());

            // Write data using BinaryWriter
            BinaryWriter writer = new BinaryWriter(File.Open("SampleData.dat", FileMode.Create));
            writer.Write(roll);
            writer.Write(name);
            writer.Write(gpa);
            writer.Close();

            Console.WriteLine("\nData stored successfully.");

            // Read data using BinaryReader
            BinaryReader reader = new BinaryReader(File.Open("student.dat", FileMode.Open));
            int r = reader.ReadInt32();
            string n = reader.ReadString();
            double g = reader.ReadDouble();
            reader.Close();

            Console.WriteLine("\nRetrieved Data:");
            Console.WriteLine("Roll No: " + r);
            Console.WriteLine("Name: " + n);
            Console.WriteLine("GPA: " + g);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
