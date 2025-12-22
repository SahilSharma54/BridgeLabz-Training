using System;

class VoteDecider{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int age=int.Parse(Console.ReadLine());
		
		// Condition for checking the eligibilty and displaying the result
		if(age>=18){
			Console.WriteLine("The person's age is "+age+" and can vote.");
		}
		else{
			Console.WriteLine("The person's age is "+age+" and cannot vote.");
		}
		
		
    }
}