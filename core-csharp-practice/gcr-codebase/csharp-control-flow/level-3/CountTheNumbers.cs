using System;

class CountTheNumbers{
	static void Main(String[] args){
		
		// Taking the value of number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a variable for count
		int count=0;
		
		// Using the while loop to iterate till number 0
		while(number!=0){
			
		   // Removing the last digit
		   number=number/10;
		   
		   // counting 
			count++;
			
		}
		
		Console.WriteLine("The Number of Digits are : "+count);
		
	}
}