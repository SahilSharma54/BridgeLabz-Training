using System;
using System.Collections;

class CircularTour
{
    static void Main()
    {
        Console.Write("Enter number of petrol pumps: ");
        int n = int.Parse(Console.ReadLine());

        int[] petrol = new int[n];
        int[] distance = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Petrol: ");
            petrol[i] = int.Parse(Console.ReadLine());
            Console.Write("Distance: ");
            distance[i] = int.Parse(Console.ReadLine());
        }

        int start = 0, balance = 0, deficit = 0;

        for (int i = 0; i < n; i++)
        {
            balance += petrol[i] - distance[i];

            if (balance < 0)
            {
                start = i + 1;
                deficit += balance;
                balance = 0;
            }
        }

        if (balance + deficit >= 0)
            Console.WriteLine("Start at pump: " + start);
        else
            Console.WriteLine("No possible tour");
    }
}
