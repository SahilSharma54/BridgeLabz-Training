using System;

class InsertionSort
{
    static void Main()
    {
        // Ask number of employees
        Console.Write("Enter number of employees: ");
        int totalEmployees = int.Parse(Console.ReadLine());

        // Array to store employee IDs
        int[] employeeIds = new int[totalEmployees];

        // Taking employee ID input
        for (int index = 0; index < totalEmployees; index++)
        {
            Console.Write("Enter Employee ID " + (index + 1) + ": ");
            employeeIds[index] = int.Parse(Console.ReadLine());
        }

        // Insertion Sort logic
        for (int currentIndex = 1; currentIndex < totalEmployees; currentIndex++)
        {
            int currentValue = employeeIds[currentIndex];
            int previousIndex = currentIndex - 1;

            // Move larger elements one position ahead
            while (previousIndex >= 0 && employeeIds[previousIndex] > currentValue)
            {
                employeeIds[previousIndex + 1] = employeeIds[previousIndex];
                previousIndex--;
            }

            // Place current value at correct position
            employeeIds[previousIndex + 1] = currentValue;
        }

        // Display sorted employee IDs
        Console.WriteLine("Sorted Employee IDs:");
        for (int index = 0; index < totalEmployees; index++)
        {
            Console.Write(employeeIds[index] + " ");
        }
    }
}
