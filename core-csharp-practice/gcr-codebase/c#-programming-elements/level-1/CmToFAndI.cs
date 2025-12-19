using System;

class CmToFAndI{
	static void Main(String[] args){
		
		// Creating variable to store the height from the user
		float height=float.Parse(Console.ReadLine());
		
		// Creating variable for inches and feets
		double inch=height/(2.54*2.54);
		double feet=inch/(12*12);
		
		// Displaying the results
		Console.WriteLine("Your Height in cm is "+height+" while in feet is "+feet+" and inches id "+inch);
	}
}