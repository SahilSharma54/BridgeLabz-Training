using System;

class CounterForLoop{
	static void Main(String[] args){
		
		// Get the input value of counter from the user 
		int counter=int.Parse(Console.ReadLine());
		
		// Condition for starting counter from n to 1 and displaying the result
		if(counter==1){
			Console.WriteLine("Counter already 1");
		}
		else{
			for(;counter>=1;counter--){
				Console.WriteLine("Count Down is : "+counter);
			}
		}
	}
		
}
