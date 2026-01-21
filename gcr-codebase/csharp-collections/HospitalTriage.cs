using System;
using System.Collections.Generic;

class HospitalTriage
{
    static void Main()
    {
        Console.Write("Enter number of patients: ");
        int n = int.Parse(Console.ReadLine());

        // We’ll use two queues as an example: one for high severity, one for low severity
        Queue<string> highSeverity = new Queue<string>();
        Queue<string> mediumSeverity = new Queue<string>();
        Queue<string> lowSeverity = new Queue<string>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter severity (1=low, 2=medium, 3=high): ");
            int severity = int.Parse(Console.ReadLine());

            if (severity == 3)
                highSeverity.Enqueue(name);
            else if (severity == 2)
                mediumSeverity.Enqueue(name);
            else
                lowSeverity.Enqueue(name);
        }

        Console.WriteLine("\nTreatment Order:");

        // Treat high severity first
        while (highSeverity.Count > 0)
            Console.WriteLine(highSeverity.Dequeue());

        // Then medium severity
        while (mediumSeverity.Count > 0)
            Console.WriteLine(mediumSeverity.Dequeue());

        // Then low severity
        while (lowSeverity.Count > 0)
            Console.WriteLine(lowSeverity.Dequeue());
    }
}
