using System;

class Course{
	
    // Instance variables to store course details
    string courseName;
    int duration;
    double fee;

    // Static variable shared by all objects
    static string instituteName = "ABC Institute";

    // Constructor to initialize course details
    public Course(string name, int dur, double f){
		
        courseName = name;
        duration = dur;
        fee = f;
    }

    // Method to display course information
    public void DisplayCourseDetails(){
		
        Console.WriteLine("Course Name: " + courseName);
        Console.WriteLine("Duration: " + duration + " months");
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Institute: " + instituteName);
    }

    // Static method to update institute name
    public static void UpdateInstituteName(string name){
		
        instituteName = name;
    }
}

class Program{
	
    static void Main(){
		
        // Updating the institute name using static method
        Course.UpdateInstituteName("Code Academy");

        // Creating a Course object
        Course c1 = new Course("C#", 3, 5000);

        // Displaying course details
        c1.DisplayCourseDetails();
    }
}
