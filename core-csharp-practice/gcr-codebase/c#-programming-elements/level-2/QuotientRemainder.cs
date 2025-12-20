using System;

class QuotientRemainder{
	static void Main(String[] args){
		// Creating variables for storing number1 and number2 from user
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		
		// Calculating Quotient and Remainder
		int Quotient=number1/number2;
		int Remainder=number1%number2;
		
		// Displaying the results
		Console.WriteLine("The Quotient is "+Quotient+"and Remainder is "+Remainder+" of two numbers "+number1+" and "+number2);
		
	}
}