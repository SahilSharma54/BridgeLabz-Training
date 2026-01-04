using System;

class Employee{
	
    string name;
    int id;
    double salary;

    // Method to set values
    public void GetDetails(){
		
        Console.Write("Enter Employee Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Employee ID: ");
        id = int.Parse(Console.ReadLine());

        Console.Write("Enter Salary: ");
        salary = double.Parse(Console.ReadLine());
    }

    // Method to display details
    public void DisplayDetails(){
		
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Salary: " + salary);
    }
}

class Program{
	
    static void Main(string[] args){
		
        Employee emp = new Employee();
        emp.GetDetails();
        emp.DisplayDetails();
    }
}
