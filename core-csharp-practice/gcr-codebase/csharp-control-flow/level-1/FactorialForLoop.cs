using System;

class FactorialForLoop{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int factorial=int.Parse(Console.ReadLine());
		int factorialTotal=1;
		
		// Checking For natural number
		if(factorial>=1){
			Console.WriteLine("It is a Natual Number");
		}
		
		// using for loop calculating the factorial
		for(;factorial>=1;factorial--){
			factorialTotal=factorialTotal*factorial;
			
		}
		
		// Displaying the Result
			Console.WriteLine("Factorial  is : "+factorialTotal);
    }
}