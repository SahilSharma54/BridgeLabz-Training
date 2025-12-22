using System;

class NumberChecker{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int number=int.Parse(Console.ReadLine());
		
		// Condition for checking the nature and displaying the result
		if(number>0){
			Console.WriteLine("positive");
		}
		else if(number==0){
			Console.WriteLine("zero");
		}
		else{
			Console.WriteLine("negative");
		}
		
    }
}