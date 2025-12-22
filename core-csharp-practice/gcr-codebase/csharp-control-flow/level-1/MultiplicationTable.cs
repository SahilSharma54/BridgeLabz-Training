using System;

class MultiplicationTable{
	static void Main(String[] args){
		
		// Taking the input integer value from the user
		int number=int.Parse(Console.ReadLine());
		
		// using for loop to display the table
		for(int iterator=6;iterator<=9;iterator++){
			Console.WriteLine(number+" X "+iterator+" = "+number*iterator);
		}
	}
}