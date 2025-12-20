using System;

class PoundsToKilograms{
	static void Main(String[] args){
		
		// Creating variables to store weight in pounds from the user
		int weightInPounds=int.Parse(Console.ReadLine());
		
		// Calculating the weight in kg
		double weightInKg=0.453592*weightInPounds;
		
		// Displaying the results
		Console.WriteLine("The weight of the person in pounds is "+weightInPounds+" and in kg is "+weightInKg);
		
	}
}