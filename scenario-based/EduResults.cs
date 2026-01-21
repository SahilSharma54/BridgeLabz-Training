/*

EduResults – Rank Sheet Generator (Merge Sort)
Story: An educational board compiles marks of thousands of students from different districts.
Each district submits a sorted list of students by score. The main server needs to merge and
sort all these lists into a final state-wise rank list. Merge Sort ensures efficiency and maintains
stability for duplicate scores.
Concepts Involved:
● Merge Sort
● Merging sorted sublists
● Large datasets with stable sorting

*/

using System;
using System.Collections.Generic;


// Interface hides implementation details
interface ISortOperation
{
    void Sort();
}


// Base class with protected data
class StudentMarks
{
    protected List<int> marks = new List<int>();

    // Method to add marks
    public void AddMarks(int mark)
    {
        marks.Add(mark);
    }

    // Method to display marks
    public void DisplayMarks()
    {
        int rank = 1;
        foreach (int m in marks)
        {
            Console.WriteLine("Rank " + rank + " : " + m);
            rank++;
        }
    }
}


// Derived class inherits StudentMarks
class MergeSortGenerator : StudentMarks, ISortOperation
{
    
    // Overridden sort method
    public void Sort()
    {
        MergeSort(0, marks.Count - 1);
    }
    

    // Merge Sort logic
    private void MergeSort(int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(left, mid);
            MergeSort(mid + 1, right);
            Merge(left, mid, right);
        }
    }

    // Merge two sorted sublists
    private void Merge(int left, int mid, int right)
    {
        List<int> temp = new List<int>();
        int i = left, j = mid + 1;

        while (i <= mid && j <= right)
        {
            if (marks[i] <= marks[j]) // Stable sorting
                temp.Add(marks[i++]);
            else
                temp.Add(marks[j++]);
        }

        while (i <= mid)
            temp.Add(marks[i++]);

        while (j <= right)
            temp.Add(marks[j++]);

        for (int k = 0; k < temp.Count; k++)
            marks[left + k] = temp[k];
    }
}


// Main class
class EduResultsApp
{
    static void Main()
    {
        MergeSortGenerator generator = new MergeSortGenerator();
        int choice;

        do
        {
            Console.WriteLine("\n===== EduResults – Rank Sheet Generator =====");
            Console.WriteLine("1. Enter District Marks");
            Console.WriteLine("2. Generate State-wise Rank List");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter number of students: ");
                    int n = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter marks (sorted):");
                    for (int i = 0; i < n; i++)
                    {
                        generator.AddMarks(int.Parse(Console.ReadLine()));
                    }
                    break;

                case 2:
                    generator.Sort();
                    Console.WriteLine("\nFinal State Rank List:");
                    generator.DisplayMarks();
                    break;

                case 3:
                    Console.WriteLine("Program Ended");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 3);
    }
}
