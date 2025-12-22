using System;

class SumOfNumbersForLoop{
	static void Main(String[] args){
		
		// Get the input value of total, natual number from the user 
		int sumNatural=0;
		int formulaNatural=0;
		int number=int.Parse(Console.ReadLine());
		
		// Condition for taking the input is a natural number or not
		if(number>=1){
			formulaNatural=number*(number+1)/2;
			int tempForNumber=number;
		for(;tempForNumber>=1;tempForNumber--){
			sumNatural+=tempForNumber;
			
		}
		}
		
		
		// Displaying the Output
		if(sumNatural==formulaNatural){
		    Console.WriteLine("The values of Both Operations are : Correct");
		}
		else{
			Console.WriteLine("The values of Both Operations are : Incorrect");
		}
	}
		
}