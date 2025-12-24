using System;

class OddEven{
	static void Main(String[] args){
		
		// Implementing array with the given size
		int[] arrayOfNumbers=new int[5];   // Have to increase the size of array by one for out of bound expection
		
		// Taking the input of array from the user and display the output also as follows
		for(int iterator=0;iterator<arrayOfNumbers.Length;iterator++){
			arrayOfNumbers[iterator]=int.Parse(Console.ReadLine());
			if(arrayOfNumbers[iterator]>0){
				if(arrayOfNumbers[iterator]%2==0){
					Console.WriteLine("Even");
				}
				else{
					Console.WriteLine("odd");
				}
			}
			else if(arrayOfNumbers[iterator]==0){
				Console.WriteLine("zero");
			}
			
		}
		// Checking first and last element of the array if they are equal, greater or less
			
			if(arrayOfNumbers[0]==arrayOfNumbers[arrayOfNumbers.Length-1]){
				Console.WriteLine("Equal");
			}
			else if(arrayOfNumbers[0]>arrayOfNumbers[arrayOfNumbers.Length-1]){
				Console.WriteLine("Greater");
			}
			else{
				Console.WriteLine("Less");
			}
	}
}
