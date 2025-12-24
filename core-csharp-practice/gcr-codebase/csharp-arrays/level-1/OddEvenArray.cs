using System;

class OddEvenArray{
	static void Main(String[] args){
		
		// Taking the value of number from the user
		int number=int.Parse(Console.ReadLine());
		
		// checking if the number is natural number or not
		if(number>=1){
			
			// creating the array and variables according to the question
			int[] numbersEven=new int[number/2+1];
			int[] numbersOdd=new int[number/2+1];
			int evenIndex=0;
			int oddIndex=0;
			
			// using for loop to enter the values
			for(int iterator=1;iterator<number;iterator++){
				if(iterator%2==0){
					numbersEven[evenIndex]=iterator;
					evenIndex++;
				}
				else{
					numbersOdd[oddIndex]=iterator;
					oddIndex++;
				}
			}
			
			// displaying the odd and even arrays
			for(int iterator=0;iterator<=evenIndex;iterator++){
				Console.WriteLine("This is even : "+numbersEven[iterator]);
			}
			
			for(int iterator=0;iterator<=oddIndex;iterator++){
				Console.WriteLine("This is odd : "+numbersOdd[iterator]);
			}
			
			
		}
		else{
			Console.WriteLine("Error is Thrown");
		}
		
			
		
	}
}