using System;

class NumberOfHandShakes{
	static void Main(String[] args){
	
	// Creating variable to store Number of Students
	int numberOfStudents=int.Parse(Console.ReadLine());
	
	// Performing the calculation for number of handshakes
	int numberOfHandShakes=(numberOfStudents*(numberOfStudents-1))/2;
	
	// Displaying the output
	Console.WriteLine(numberOfHandShakes);
	
    }
}