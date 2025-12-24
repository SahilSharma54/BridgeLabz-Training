using System;

class MultiplicationTableRange{
	static void Main(String[] args){
		
		// Creating the variable for taking a number from the user
		int number=int.Parse(Console.ReadLine());
		
		// Implementing array with the given size
		int[] arrayOfNumber=new int[4];
		
		// Taking the input of array from the user and display the output also as follows
		for(int iterator=6;iterator<=9;iterator++){
			
			arrayOfNumber[iterator-6]=number*iterator;
			
		}
			
		// Displaying the result
		for(int iterator=6;iterator<=9;iterator++){
			
			Console.WriteLine(number+" * "+iterator+" = "+arrayOfNumber[iterator-6]);
			
		}
	}
}