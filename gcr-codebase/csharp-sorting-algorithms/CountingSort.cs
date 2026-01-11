using System;

class CountingSort
{
    static void Main()
    {
        // Ask number of students
        Console.Write("Enter number of students: ");
        int totalStudents = int.Parse(Console.ReadLine());

        // Array to store student ages
        int[] studentAges = new int[totalStudents];

        int minimumAge = 10;
        int maximumAge = 18;

        // Taking valid age input
        for (int index = 0; index < totalStudents; index++)
        {
            Console.Write("Enter age of student " + (index + 1) + ": ");
            int enteredAge = int.Parse(Console.ReadLine());

            // Validate age range
            if (enteredAge < minimumAge || enteredAge > maximumAge)
            {
                Console.WriteLine("Age must be between 10 and 18. Enter again.");
                index--;   // repeat same index
            }
            else
            {
                studentAges[index] = enteredAge;
            }
        }

        // Count array
        int[] ageCount = new int[maximumAge - minimumAge + 1];

        // Store frequency of each age
        for (int index = 0; index < totalStudents; index++)
        {
            ageCount[studentAges[index] - minimumAge]++;
        }

        // Rebuild sorted array
        int sortedIndex = 0;

        for (int age = minimumAge; age <= maximumAge; age++)
        {
            while (ageCount[age - minimumAge] > 0)
            {
                studentAges[sortedIndex] = age;
                sortedIndex++;
                ageCount[age - minimumAge]--;
            }
        }

        // Display sorted ages
        Console.WriteLine("Sorted Student Ages:");
        for (int index = 0; index < totalStudents; index++)
        {
            Console.Write(studentAges[index] + " ");
        }
    }
}
