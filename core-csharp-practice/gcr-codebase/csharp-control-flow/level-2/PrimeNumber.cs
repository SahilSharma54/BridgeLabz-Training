using System;

class PrimeNumber{
	
	static void Main(String[] args){
		
		// Taking the number as input from the user
		int number=int.Parse(Console.ReadLine());
		
		// Taking the variable isPrime to store the result
		bool isPrime=true;
		
		// Checking if a particular number is even or odd using for loop
		for(int iterator=2;iterator<number;iterator++){
			if(number%iterator==0){
				isPrime=false;
				break ;
			}
		}
		
		// Displaying the results
		if(isPrime){
		    Console.WriteLine("The Given number is prime");
		}
		else{
			Console.WriteLine("The Given number is not prime");
		}
		
	}
	
}