using System;
using System.Collections.Generic;

// Abstract Job Role
abstract class JobRole
{
    public string CandidateName;

    // Each job role must implement screening logic
    public abstract void ScreenResume();
}

// Software Engineer role
class SoftwareEngineer : JobRole
{
    public override void ScreenResume()
    {
        Console.WriteLine(CandidateName +" screened for Software Engineer role");
    }
}

// Data Scientist role
class DataScientist : JobRole
{
    public override void ScreenResume()
    {
        Console.WriteLine(CandidateName+" screened for Data Scientist role");
    }
}

// Generic Resume processor
class Resume<T> where T : JobRole
{
    private List<T> resumes = new List<T>();

    // Add resume
    public void AddResume(T resume)
    {
        resumes.Add(resume);
    }

    // Process all resumes
    public void ProcessResumes()
    {
        foreach (T r in resumes)
            r.ScreenResume();
    }
}

class Program
{
    static void Main()
    {
        Resume<JobRole> resumeSystem = new Resume<JobRole>();
        int choice;

        do
        {
            Console.WriteLine("--- Resume Screening Menu ---");
            Console.WriteLine("1. Add Software Engineer Resume");
            Console.WriteLine("2. Add Data Scientist Resume");
            Console.WriteLine("3. Process Resumes");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter candidate name: ");
                    resumeSystem.AddResume(
                        new SoftwareEngineer { CandidateName = Console.ReadLine() }
                    );
                    break;

                case 2:
                    Console.Write("Enter candidate name: ");
                    resumeSystem.AddResume(
                        new DataScientist { CandidateName = Console.ReadLine() }
                    );
                    break;

                case 3:
                    resumeSystem.ProcessResumes();
                    break;
            }

        } while (choice != 4);
    }
}
