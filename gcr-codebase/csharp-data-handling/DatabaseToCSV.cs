using System;
using System.IO;

class DatabaseToCSV
{
    static void Main()
    {
        string[] data =
        {
            "ID,Name,Department,Salary",
            "1,Sahil,IT,50000",
            "2,Sajal,HR,45000"
        };

        File.WriteAllLines("report.csv", data);
        Console.WriteLine("CSV report generated");
    }
}
