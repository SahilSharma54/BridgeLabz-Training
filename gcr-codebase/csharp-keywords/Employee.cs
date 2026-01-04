using System;

class Employee{
	
    // static variable
    public static string CompanyName = "Tech Solutions";

    // readonly variable
    public readonly int Id;

    // instance variables
    public string Name;
    public string Designation;

    // static counter
    static int totalEmployees = 0;

    // constructor using 'this'
    public Employee(int id, string name, string designation){
		
        this.Id = id;
        this.Name = name;
        this.Designation = designation;
        totalEmployees++;
    }

    // static method
    public static void DisplayTotalEmployees(){
		
        Console.WriteLine("Total Employees: " + totalEmployees);
    }

    // display method
    public void DisplayDetails(){
		
        Console.WriteLine("Company Name: " + CompanyName);
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Designation: " + Designation);
    }
}

class Program{
	
    static void Main(){
		
        Employee emp1 = new Employee(101, "Amit", "Developer");

        // is operator
        if (emp1 is Employee){
			
            emp1.DisplayDetails();
        }

        Employee.DisplayTotalEmployees();
    }
}
