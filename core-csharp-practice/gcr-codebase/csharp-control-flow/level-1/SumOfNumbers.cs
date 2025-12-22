using System;

class SumOfNumbers{
	static void Main(String[] args){
		
		// Get the input value of total, number from the user 
		double total=0.0;
		double number=double.Parse(Console.ReadLine());
		
		// Condition for taking the input until it is zero
		while(number>=1){
			Console.WriteLine("Iteration is Going On");
			total+=number;
			number=double.Parse(Console.ReadLine());
		}
		
		
		// Displaying the Output
		Console.WriteLine("Total Output is : "+total);
		
	}
		
}
