using System;

class AbundantNumber{
	static void Main(String[] args){
		
		// Taking the value of number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a variable for sum
		int sum=0;
		
		// Finding the divisors using for loop
		for(int iterator=1;iterator<number;iterator++){
			if(number%iterator==0){
				sum+=iterator;
			}
		}
		
		// Displaying the result if abundant or not
		if(sum>number){
			Console.WriteLine("It is a Abundant Number");
		}
		else{
			Console.WriteLine("It is not a Abundant Number");
		}
		
	}
}