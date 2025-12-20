using System;

class NumberOfChocolates{
	static void Main(String[] args){
		
		// Creating the variables for storing number of chocolates and number of childrens from the user
        int numberOfChocolates=int.Parse(Console.ReadLine());		
		int numberOfChildren=int.Parse(Console.ReadLine());		
		
		// Calculating number of chocolates each children gets and remaining chocolates also
		int numberOfChocolatesEach=numberOfChocolates/numberOfChildren;
		int remainingChocolates=numberOfChocolates%numberOfChildren;
		
		// Displaying the result
		Console.WriteLine("The number of chocolates each child gets is "+numberOfChocolatesEach+" and the number of remaining chocolates is "+remainingChocolates);
	}
	
}