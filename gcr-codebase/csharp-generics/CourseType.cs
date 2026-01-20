using System;
using System.Collections.Generic;

// Abstract course type
abstract class CourseType
{
    public string CourseName;

    // Evaluation method
    public abstract void Evaluate();
}

// Exam based course
class ExamCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " evaluated through Exam");
    }
}

// Assignment based course
class AssignmentCourse : CourseType
{
    public override void Evaluate()
    {
        Console.WriteLine(CourseName + " evaluated through Assignment");
    }
}

// Generic course manager
class Course<T> where T : CourseType
{
    // List to store courses
    private List<T> courses = new List<T>();

    // Add course
    public void AddCourse(T course)
    {
        courses.Add(course);
    }

    // Evaluate all courses
    public void EvaluateCourses()
    {
        foreach (T c in courses)
            c.Evaluate();
    }
}

class Program
{
    static void Main()
    {
        Course<CourseType> manager = new Course<CourseType>();
        int choice;

        do
        {
            Console.WriteLine("--- Course Management Menu ---");
            Console.WriteLine("1. Add Exam Course");
            Console.WriteLine("2. Add Assignment Course");
            Console.WriteLine("3. Evaluate Courses");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter course name: ");
                    manager.AddCourse(new ExamCourse { CourseName = Console.ReadLine() });
                    break;

                case 2:
                    Console.Write("Enter course name: ");
                    manager.AddCourse(new AssignmentCourse { CourseName = Console.ReadLine() });
                    break;

                case 3:
                    manager.EvaluateCourses();
                    break;
            }
        } while (choice != 4);
    }
}
