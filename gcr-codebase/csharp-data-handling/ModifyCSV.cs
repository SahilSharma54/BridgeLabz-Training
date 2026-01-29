using System;
using System.IO;

class ModifyCSV
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("SampleData.csv");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (data[2] == "IT")
            {
                double salary = double.Parse(data[3]);
                salary += salary * 0.10;
                data[3] = salary.ToString();
                lines[i] = string.Join(",", data);
            }
        }

        File.WriteAllLines("employees_updated.csv", lines);
        Console.WriteLine("Updated CSV file created");
    }
}
