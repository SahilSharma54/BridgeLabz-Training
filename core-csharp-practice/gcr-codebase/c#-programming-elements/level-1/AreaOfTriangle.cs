using System;

class AreaOfTriangle{
	static void Main(String[] args){
		
		// Creating the variables and storing the values from the user
		int bases=int.Parse(Console.ReadLine());
		int height=int.Parse(Console.ReadLine());
		
		// Calculating the area of the triangle
		double areaOfTriangle=(1.0/2.0)*bases*height;
		
		// Creating variable for inches and feets
		double inch=areaOfTriangle/(2.54*2.54);
		double feet=inch/(12*12);
		
		// here in this question it is asked to show the area of triangle 
		
		// Displaying the result
		Console.WriteLine("Area of Triangle in cm "+areaOfTriangle+" while in feet "+feet+" and inches is "+inch);
	}
}