using System;

class FrizzBuzzWhileLoop{
	
	static void Main(String[] args){
		
		// Taking the number as input from the user
		int number=int.Parse(Console.ReadLine());
		
		// Checking for a positive number and printing multiples in terms of Fizz and FizzBuzz
		if(number>=1){
			
			// Initializing value of iterator
			int iterator=0;
			
			while(iterator<=number){  // using while loop
				if(iterator%3==0 && iterator%5==0){
					Console.WriteLine("FrizzBuzz"); // multiple of both 3 and 5
				}
				else if(iterator%3==0){
					Console.WriteLine("Frizz"); // multiple of 3
				}
				else if(iterator%5==0){
					Console.WriteLine("Buzz");  // multiple of 5
				}
				else{
					Console.WriteLine("Number is : "+iterator);
				}
				iterator++;
			}
		}
	}

}
