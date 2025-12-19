using System;

class Calculator{
	static void Main(String[] args){
	
	// Creating variables for num1 and num2
	int number1=int.Parse(Console.ReadLine());
	int number2=int.Parse(Console.ReadLine());
	
	// Performing the operation on the variables
	int addition=number1+number2;
	int subtraction=number1-number2;
	int multiplication=number1*number2;
	int division=number1/number2;
	
	// Displaying the results
	Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers "+number1+" and "+number2+" is "+addition+" , "+subtraction+" , "+multiplication+" , "+" and "+division);
	}
}