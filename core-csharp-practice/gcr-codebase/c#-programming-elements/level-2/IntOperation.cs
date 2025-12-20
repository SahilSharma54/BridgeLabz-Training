using System;

class IntOperation{
	static void Main(String[] args){
		
		// Creating variables for storing the values of a,b,c from the user
		int a=int.Parse(Console.ReadLine());
		int b=int.Parse(Console.ReadLine());
		int c=int.Parse(Console.ReadLine());
		
		// Performing the Int Operation and assigning them in each variables
		int operationOne=a+b*c;
		int operationTwo=a*b+c;
		int operationThree=c+a/b;
		int operationFour=a%b+c;
		
		// Displaying the Output
		Console.WriteLine("The results of Int Operations are "+operationOne+" , "+operationTwo+" , "+operationThree+ " and "+operationFour);
	}
}