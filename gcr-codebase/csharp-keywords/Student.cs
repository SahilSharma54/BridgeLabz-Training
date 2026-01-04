using System;

class Student{
	
    // static variable
    public static string UniversityName = "GLA University";

    // readonly variable
    public readonly int RollNumber;

    // instance variables
    public string Name;
    public string Grade;

    // static counter
    static int totalStudents = 0;

    // constructor using 'this'
    public Student(int roll, string name, string grade){
		
        this.RollNumber = roll;
        this.Name = name;
        this.Grade = grade;
        totalStudents++;
    }

    // static method
    public static void DisplayTotalStudents(){
		
        Console.WriteLine("Total Students: " + totalStudents);
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("University: " + UniversityName);
        Console.WriteLine("Roll Number: " + RollNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Grade: " + Grade);
    }
}

class Program{
	
    static void Main(){
		
        Student s1 = new Student(101, "Sahil", "A");

        // is operator
        if (s1 is Student){
			
            s1.DisplayDetails();
        }

        Student.DisplayTotalStudents();
    }
}
