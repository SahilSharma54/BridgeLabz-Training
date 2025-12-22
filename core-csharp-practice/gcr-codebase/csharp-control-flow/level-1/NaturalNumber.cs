using System;

class NaturalNumber{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int number1=int.Parse(Console.ReadLine());
		
		// Calculating Natural Number Sum
		int naturalSum=number1*(number1+1)/2;
		
		// Condition for checking the Natual number
		if(number1<=0){
			Console.WriteLine("The number "+number1+" is not a natural number");
		}
		else{
			Console.WriteLine("The Sum of "+number1+" is"+naturalSum);
		}
		
		
    }
}