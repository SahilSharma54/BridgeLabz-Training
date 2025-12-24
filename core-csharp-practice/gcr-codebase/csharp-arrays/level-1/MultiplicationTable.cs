using System;

class MultiplicationTable{
	static void Main(String[] args){
		
		// Creating the variable for taking a number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Implementing array with the given size
		int[] arrayOfNumber=new int[10];
		
		// Taking the input of array from the user and display the output also as follows
		for(int iterator=1;iterator<arrayOfNumber.Length;iterator++){
			
			arrayOfNumber[iterator]=number*iterator;
			
		}
			
		// Displaying the result
		for(int iterator=0;iterator<arrayOfNumber.Length;iterator++){
			
			Console.WriteLine(arrayOfNumber[iterator]);
			
		}
	}	
			
}
