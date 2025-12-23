using System;

class GreatestFactor{
	static void Main(String[] agrs){
		
		// Taking the input value of the number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Assigning the value of greatestFactor value
		int greatestFactor=1;
		
		// Using the for loop for the checking if the number is the greatestFactor
		for(int iterator=number-1;iterator>=1;iterator--){
			if(number%iterator==0){
				greatestFactor=iterator;
				break;
			}
		}
		
		// Displaying the result
		Console.WriteLine("GreatestFactor is : "+greatestFactor);
		
	}
}