using System;
using System.IO;

class WriteCSV
{
    static void Main()
    {
        string[] employees =
        {
            "ID,Name,Department,Salary",
            "1,Sahil,IT,50000",
            "2,Riya,HR,45000",
            "3,Sajal,IT,60000",
            "4,Neha,Finance,55000",
            "5,Arjun,IT,70000"
        };

        File.WriteAllLines("employees.csv", employees);
        Console.WriteLine("CSV file written successfully");
    }
}
