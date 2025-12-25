using System;

class SimpleInterestFinding{
	
	static int SimpleInterest(int principal,int rate,int time){
		
		// Creating a variable for storing the result
		int simpleInterest=(principal*rate*time)/100;
		return simpleInterest;
	}
	
	static void Main(String[] args){
		
		// Taking the input of principal, rate, and time from the user
		int principal=int.Parse(Console.ReadLine());
		int rate=int.Parse(Console.ReadLine());
		int time=int.Parse(Console.ReadLine());
		
		// Sending the values to the method for calculations and displaying the result
		Console.WriteLine(SimpleInterest(principal,rate,time));
		
	}
}