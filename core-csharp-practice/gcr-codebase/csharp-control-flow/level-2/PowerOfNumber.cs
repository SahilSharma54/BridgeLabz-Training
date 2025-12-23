using System;

class PowerOfNumber{
	static void Main(String[] args){
		
		// Taking the input value of the number and power from the user
		int number=int.Parse(Console.ReadLine());
		int power=int.Parse(Console.ReadLine());
		
		// Assigning the value of result variable 
		int result=1;
		
		// Using the for loop for the checking multiplication
		for(int iterator=1;iterator<=power;iterator++){
			result*=number;
		}
		
		// Displaying the result
		Console.WriteLine("Power of the Number is : "+result);
		
		
	}
}