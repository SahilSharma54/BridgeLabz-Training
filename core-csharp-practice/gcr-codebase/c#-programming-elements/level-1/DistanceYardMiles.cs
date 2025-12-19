using System;
class DistanceYardMiles{
	static void Main(String[] args){
		
		// Creating variable for storing distance in feet
		int distanceInFeet=int.Parse(Console.ReadLine());
		
		// Creating variable to store yards and miles
		double distanceInYards=distanceInFeet/3.0;
		
		double distanceInMiles=distanceInFeet/5280.0;
		
		// Displaying the result
		Console.WriteLine("Your distance in feet is "+distanceInFeet+" while in yards is "+distanceInYards+" and in miles is "+distanceInMiles);
	}
}