using System;

class Student{
	
    // Public variable (accessible everywhere)
    public int rollNumber;

    // Protected variable (accessible in derived classes)
    protected string name;

    // Private variable (accessible only inside this class)
    private double cgpa;

    // Constructor to initialize student details
    public Student(int roll, string n, double c){
		
        rollNumber = roll;
        name = n;
        cgpa = c;
    }

    // Method to update CGPA
    public void SetCGPA(double c){
		
        cgpa = c;
    }

    // Method to get CGPA value
    public double GetCGPA(){
		
        return cgpa;
    }
}

// Child class inheriting from Student
class PostgraduateStudent : Student{
	
    // Constructor calling base class constructor
    public PostgraduateStudent(int r, string n, double c) : base(r, n, c) { }

    // Method to display student details
    public void Display(){
		
        Console.WriteLine("Roll No: " + rollNumber);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("CGPA: " + GetCGPA());
    }
}

class Program{
	
    static void Main(){
		
        // Creating object of PostgraduateStudent
        PostgraduateStudent s = new PostgraduateStudent(101, "Amit", 8.5);

        // Display student details
        s.Display();
    }
}
