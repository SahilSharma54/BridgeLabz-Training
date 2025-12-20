using System;

class AthleteRound{
	static void Main(String[] args){
		
		// Creating variable for storing the values of side1, side2, side3 from the user
		int side1=int.Parse(Console.ReadLine());
		int side2=int.Parse(Console.ReadLine());
		int side3=int.Parse(Console.ReadLine());
		double distance=5000; // 5km into meters distance is given
		
		// Calculating the perimeter of triangle and the number of rounds
		int perimeterOfTriangle=side1+side2+side3;
		double rounds=distance/perimeterOfTriangle;
		
		// Displaying the results
		Console.WriteLine(" The total number of rounds the athlete will run is "+rounds+" to complete 5 km");
		
	}
}