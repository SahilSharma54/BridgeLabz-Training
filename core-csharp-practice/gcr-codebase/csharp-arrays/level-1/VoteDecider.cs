using System;

class VoteDecider{
	static void Main(String[] args){
		
		// Implementing array with the given size
		int[] arrayOfAge=new int[10];
		
		// Taking the input of array from the user and display the output also as follows
		for(int iterator=0;iterator<arrayOfAge.Length;iterator++){
			arrayOfAge[iterator]=int.Parse(Console.ReadLine());
			if(arrayOfAge[iterator]>=18){
				Console.WriteLine("The Student with the age "+arrayOfAge[iterator]+" can vote");
			}
			else{
				Console.WriteLine("The Student with the age "+arrayOfAge[iterator]+" can not vote");
			}
		}
			
	}
}