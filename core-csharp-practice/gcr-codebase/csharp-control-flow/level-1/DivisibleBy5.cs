using System;

class DivisibleBy5{
	static void Main(String[] args){
		
		// Get the input value from the user 
		int number=int.Parse(Console.ReadLine());
		
		// Condition for checkinng the divisibility
		bool result=false;
		if(number%5==0){
			result=true;
		}
		
		// Displaying the result
	Console.WriteLine("Is the number "+number+" divisible by 5? "+result);
    }
}