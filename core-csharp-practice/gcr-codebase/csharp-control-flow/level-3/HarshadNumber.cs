using System;

class HarshadNumber{
	static void Main(String[] args){
		
		// Taking the value of number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a variable for copying the variable 
		int temporary=number;
		
		// Creating a variable for accessing the digits and the sum
		int digit=0;
		int sum=0;
	 	
		// Using the while loop to iterate till number 0
		while(number!=0){
			
		   // Taking the last digit
		   digit=number%10;
		   sum+=digit;
		   number=number/10;
		   
		}
		
		// Checking if the number is divisible by sum
		if(temporary%sum==0){
			Console.WriteLine("It is a Harshad Number");
		}
		else{
			Console.WriteLine("It is not a Harshad Number");
		}
		
		
	}
}