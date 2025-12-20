using System;

class SwapTwoNumber{
	static void Main(String[] args){
		
		// Creating variables to store the values of number1 and number2 from the user
		int number1=int.Parse(Console.ReadLine());
		int number2=int.Parse(Console.ReadLine());
		
		// Swapping the Numbers
		int temporary=0;
		temporary=number1;
		number1=number2;
		number2=temporary;
		
		// Displaying the Results
		Console.WriteLine("The Swapped numbers are "+number1+" and "+number2);
		
    }
}