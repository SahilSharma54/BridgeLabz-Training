using System;

class Factorial{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int factorial=int.Parse(Console.ReadLine());
		int factorialTotal=1;
		
		// using while calculating the factorial
		while(factorial>=1){
			factorialTotal=factorialTotal*factorial;
			factorial--;
		}
		
		// Displaying the Result
			Console.WriteLine("Factorial  is : "+factorialTotal);
    }
}