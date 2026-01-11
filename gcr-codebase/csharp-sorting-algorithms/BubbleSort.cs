using System;

class BubbleSort
{
    static void Main()
    {
        // Ask number of students
        Console.Write("Enter number of students: ");
        int totalStudents = int.Parse(Console.ReadLine());

        // Array to store student marks
        int[] studentMarks = new int[totalStudents];

        // Taking marks input
        for (int index = 0; index < totalStudents; index++)
        {
            Console.Write("Enter marks of student " + (index + 1) + ": ");
            studentMarks[index] = int.Parse(Console.ReadLine());
        }

        // Bubble Sort logic
        for (int pass = 0; pass < totalStudents - 1; pass++)
        {
            for (int compareIndex = 0; compareIndex < totalStudents - 1 - pass; compareIndex++)
            {
                // Compare adjacent elements
                if (studentMarks[compareIndex] > studentMarks[compareIndex + 1])
                {
                    // Swap if order is wrong
                    int temp = studentMarks[compareIndex];
                    studentMarks[compareIndex] = studentMarks[compareIndex + 1];
                    studentMarks[compareIndex + 1] = temp;
                }
            }
        }

        // Display sorted marks
        Console.WriteLine("Sorted Student Marks:");
        for (int index = 0; index < totalStudents; index++)
        {
            Console.Write(studentMarks[index] + " ");
        }
    }
}
