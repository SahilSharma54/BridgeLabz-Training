using System;

class Largest{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		int number3=int.Parse(Console.ReadLine());
		
		
		// declaring variable for result as boolean
		bool result1=false;
		bool result2=false;
		bool result3=false;
		
		// Condition for checking the largest number among all
		if(number1>number2 && number1>number3){
			result1=true;
		}
		else if(number2>number1 && number2>number3){
			result2=true;
		}
		else{
			result3=true;
		}
		
		// Displaying the result
	    Console.WriteLine("Is the first number the largest?"+result1);
		Console.WriteLine("Is the second number the largest?"+result2);
		Console.WriteLine("Is the third number the largest?"+result3);
    }
}