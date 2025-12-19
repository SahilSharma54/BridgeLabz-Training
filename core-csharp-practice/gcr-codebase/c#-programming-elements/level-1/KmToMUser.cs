using System;

class KmToMUser{
	static void Main(String[] args){
		
		// Creating variables Km for storing kilometers
		int km=int.Parse(Console.ReadLine());
		
		// Calculating Miles
		double Miles=1.6*km;
		
		// Displaying results
		Console.WriteLine("The total miles is "+Miles+" mile for the given "+km+" km");
	}
}
