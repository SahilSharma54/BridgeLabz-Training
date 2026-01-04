using System;

class Employee{
	
    // Public variable – accessible from anywhere
    public int employeeID;

    // Protected variable – accessible in derived (child) classes
    protected string department;

    // Private variable – accessible only inside this class
    private double salary;

    // Constructor to initialize employee details
    public Employee(int id, string dept, double sal){
		
        employeeID = id;
        department = dept;
        salary = sal;
    }

    // Method to update the salary
    public void UpdateSalary(double newSalary){
		
        salary = newSalary;
    }

    // Method to return the salary
    public double GetSalary(){
		
        return salary;
    }
}

// Child class inheriting from Employee
class Manager : Employee{
	
    // Constructor calling base class constructor
    public Manager(int id, string dept, double sal)
        : base(id, dept, sal)
    {
    }

    // Method to display manager details
    public void Display(){
		
        Console.WriteLine("Employee ID: " + employeeID);
        Console.WriteLine("Department: " + department);
        Console.WriteLine("Salary: " + GetSalary());
    }
}

class Program{
	
    static void Main(){
		
        // Creating an object of Manager class
        Manager m = new Manager(201, "IT", 45000);

        // Displaying manager details
        m.Display();

        // Updating salary
        m.UpdateSalary(55000);

        // Displaying updated salary
        Console.WriteLine("Updated Salary: " + m.GetSalary());
    }
}
