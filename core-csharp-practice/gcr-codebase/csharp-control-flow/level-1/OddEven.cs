using System;

class OddEven{
	static void Main(String[] args){
		
		// Get the integer input value from the user 
		int number=int.Parse(Console.ReadLine());
		
		// Checking the Natural number
		if(number>=1){
			Console.WriteLine("This is a Natural Number");
		}
		
		// using for loop for identifying odd and even numbers and displaying output also
		for(int iterator=1;iterator<=number;iterator++){
			if(iterator%2==0){
				Console.WriteLine("This number "+iterator+" is even");
			}
			else{
				Console.WriteLine("This number "+iterator+" is odd");
			}
			
		}
		
    }
}