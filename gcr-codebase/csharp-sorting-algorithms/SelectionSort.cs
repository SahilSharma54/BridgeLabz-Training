using System;

class SelectionSort
{
    static void Main()
    {
        // Ask number of students
        Console.Write("Enter number of students: ");
        int totalStudents = int.Parse(Console.ReadLine());

        // Array to store exam scores
        int[] examScores = new int[totalStudents];

        // Take exam scores input
        for (int index = 0; index < totalStudents; index++)
        {
            Console.Write("Enter exam score of student " + (index + 1) + ": ");
            examScores[index] = int.Parse(Console.ReadLine());
        }

        // Selection Sort logic
        for (int currentPosition = 0; currentPosition < totalStudents - 1; currentPosition++)
        {
            int minimumIndex = currentPosition;

            // Find minimum element in remaining array
            for (int nextIndex = currentPosition + 1; nextIndex < totalStudents; nextIndex++)
            {
                if (examScores[nextIndex] < examScores[minimumIndex])
                {
                    minimumIndex = nextIndex;
                }
            }

            // Swap minimum element with first unsorted element
            int temp = examScores[currentPosition];
            examScores[currentPosition] = examScores[minimumIndex];
            examScores[minimumIndex] = temp;
        }

        // Display sorted exam scores
        Console.WriteLine("Sorted Exam Scores:");
        for (int index = 0; index < totalStudents; index++)
        {
            Console.Write(examScores[index] + " ");
        }
    }
}
