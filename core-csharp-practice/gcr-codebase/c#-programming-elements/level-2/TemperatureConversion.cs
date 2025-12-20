using System;

class TemperatureConversion{
	static void Main(String[] args){
		
		// Creating variables for storing the values of celsius and fahrenheit
		float celsius=float.Parse(Console.ReadLine());
		
		// Performing the calculation for the conversion 
		float fahrenheit=(celsius*9/5)+32;
		
		// Displaying the results
		Console.WriteLine("The "+celsius+" Celsius is "+fahrenheit+" Fahrenheit");
		
	}
}