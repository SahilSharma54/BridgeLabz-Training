using System;

class SqaurePerimeter{
	
	static void Main(String[] args){
		
		// Creating variable to store the perimeter from the user
		int sideOfReatangle=int.Parse(Console.ReadLine());
		
		// Performing the calculation for the perimeter
		int perimeter=4*sideOfReatangle;
		
		// Displaying output
		Console.WriteLine(perimeter);
	}
	
}