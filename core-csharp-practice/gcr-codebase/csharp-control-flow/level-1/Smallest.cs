using System;

class Smallest{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		int number3=int.Parse(Console.ReadLine());
		
		
		// declaring variable for result as boolean
		bool result=false;
		
		// Condition for checking the smallest number
		if(number1<number2 && number2<number3){
			result=true;
		}
		
		// Displaying the result
	    Console.WriteLine("Is the first number the smallest?"+result);
    }
}