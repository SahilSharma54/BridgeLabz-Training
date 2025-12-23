using System;

class MultipleOfNumber{
	static void Main(String[] agrs){
		
		// Taking the input value of the number from the user
		int number=int.Parse(Console.ReadLine());
		
		
		// Using the for loop in backwards
		for(int iterator=100;iterator>=1;iterator--){
			if(number%iterator==0){
			   Console.WriteLine("It is a number "+iterator);
			   continue;
			}
		}
		
	}
}