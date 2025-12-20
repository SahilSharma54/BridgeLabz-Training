using System;

class DoubleOpt{
	static void Main(String[] args){
		
		// Creating variables for storing the values of a,b,c from the user
		double a=double.Parse(Console.ReadLine());
		double b=double.Parse(Console.ReadLine());
		double c=double.Parse(Console.ReadLine());
		
		// Performing the Double Operation and assigning them in each variables
		double operationOne=a+b*c;
		double operationTwo=a*b+c;
		double operationThree=c+a/b;
		double operationFour=a%b+c;
		
		// Displaying the Output
		Console.WriteLine("The results of Double Operations are "+operationOne+" , "+operationTwo+" , "+operationThree+ " and "+operationFour);
	}
}