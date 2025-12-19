using System;

class DivideEqually{
	static void Main(String[] args){
		
		// Creating variables for storing pens and student
		int pens=14;
		int students=3;
		
		// Creating variables for storing penperstudent and remainingpen
		int penPerStudent=pens/students;
		int remainingPens=students%pens;
		
		// Displaying the results
		Console.WriteLine("The Pen Per Student is "+ penPerStudent +" and the remaining pen not distributed is "+remainingPens);
	}
}