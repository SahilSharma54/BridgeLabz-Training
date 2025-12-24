using System;

class FrizzBuzz{
	static void Main(String[] args){
		
		// Taking the input as a number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Creating a string array
		string[] results=new string[number+1];
		
		// using for loop to iterate from 1 to the number
		for(int iterator=0;iterator<=number;iterator++){
			if(iterator==0){
				results[iterator]="0";
			}
			else if(iterator%3==0 && iterator%5==0){
				results[iterator]="FrizzBuzz";
			}
			else if(iterator%3==0){
				results[iterator]="Frizz";
			}
			else if(iterator%5==0){
				results[iterator]="Buzz";
			}
			else{
				results[iterator]=iterator.ToString();
			}
		}
		
		// Displaying the results
		for(int iterator=0;iterator<=number;iterator++){
			Console.WriteLine(results[iterator]);
		}
	}
}