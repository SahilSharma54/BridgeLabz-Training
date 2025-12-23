using System;

class FactorOfNumber{
	static void Main(String[] agrs){
		
		// Taking the input value of the number from the user
		int number=int.Parse(Console.ReadLine());
		
		
		// Using the for loop for the checking if the number is the factor
		for(int iterator=1;iterator<number;iterator++){
			if(number%iterator==0){
			   Console.WriteLine("It is a factor "+iterator);
			}
		}
		
	}
}