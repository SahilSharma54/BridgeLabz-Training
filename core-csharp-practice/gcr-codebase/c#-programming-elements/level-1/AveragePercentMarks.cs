using System;

class AveragePercentMarks{
	static void Main(String[] args){
		
		// Creating variables for storing marks of maths, physics, chemistry
		int maths=94;
		int physics=95;
		int chemistry=96;
		
		// Finding the average of the marks
		int average=(maths+physics+chemistry)/3;
		
		// Displaying the Result
		Console.WriteLine(average+"%");
		
	}
}