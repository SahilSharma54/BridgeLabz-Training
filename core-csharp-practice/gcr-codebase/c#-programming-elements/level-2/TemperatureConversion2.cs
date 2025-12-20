using System;

class TemperatureConversion2{
	static void Main(String[] args){
		
		// Creating variables for storing the values of celsius and fahrenheit
		float fahrenheit=float.Parse(Console.ReadLine());
		
		// Performing the calculation for the conversion 
		float celsius=(fahrenheit-32)*5/9;
		
		// Displaying the results
		Console.WriteLine("The "+fahrenheit+" Fahrenheit is "+celsius+" Celsius");
		
	}
}